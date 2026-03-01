using ZooZen.DTOs.User;
using ZooZen.Common.Constants;
using ZooZen.Services.Interfaces;
using ZooZen.Utilities;
using static ZooZen.Utilities.DynamicContentTranslator.EntitiesTranslation;

namespace ZooZen.Forms
{
    public partial class AdminUsersForm : Form
    {
        private readonly IUserService _userService;
        private UserDataViewModel? _editing = null;

        public AdminUsersForm(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();

            var nav = NavigationHelper.CreateNavigationMenu(this, AuthorizationHelper.IsAuthorized());
            Controls.Add(nav);
            nav.BringToFront();
            lblHeader.BringToFront();

            // Shift content down to account for nav height
            int navHeight = nav.PreferredSize.Height;
            lblHeader.Location = new Point(lblHeader.Location.X, navHeight);
            usersContainer.Location = new Point(usersContainer.Location.X, navHeight + lblHeader.Height);
            pnlRight.Location = new Point(pnlRight.Location.X, navHeight + lblHeader.Height);
            ClientSize = new Size(ClientSize.Width, ClientSize.Height + navHeight);
        }

        private async void AdminUsersForm_Load(object sender, EventArgs e)
        {
            await RefreshUsersListAsync();
        }

        private async Task RefreshUsersListAsync()
        {
            // Clear all except headers
            while (usersContainer.Controls.Count > 1)
                usersContainer.Controls.RemoveAt(1);

            var users = await _userService.GetUsersAsync();
            int index = 0;

            foreach (var user in users)
            {
                var userContainer = new FlowLayoutPanel
                {
                    Name = $"userContainer{index}",
                    Size = new Size(700, 50),
                    Margin = new Padding(0, 2, 0, 2),
                    BackColor = Color.White,
                    WrapContents = false
                };

                var username = new Label
                {
                    Name = $"username{index}",
                    Text = user.Username,
                    Font = new Font("Segoe UI", 10F),
                    AutoSize = false,
                    Size = new Size(120, 30),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Margin = new Padding(10, 10, 0, 0)
                };

                var fullName = new Label
                {
                    Name = $"fullName{index}",
                    Text = $"{user.FirstName} {user.LastName}".Trim(),
                    Font = new Font("Segoe UI", 10F),
                    AutoSize = false,
                    Size = new Size(130, 30),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Margin = new Padding(10, 10, 0, 0)
                };

                var phone = new Label
                {
                    Name = $"phone{index}",
                    Text = user.Phone ?? "",
                    Font = new Font("Segoe UI", 10F),
                    AutoSize = false,
                    Size = new Size(110, 30),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Margin = new Padding(10, 10, 0, 0)
                };

                var isAdminBox = new ComboBox
                {
                    Name = $"isAdmin{index}",
                    Font = new Font("Segoe UI", 10F),
                    Size = new Size(90, 30),
                    Margin = new Padding(10, 10, 0, 0),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };

                isAdminBox.Items.AddRange(new object[] { "Admin", "Client" });
                isAdminBox.SelectedIndex = user.IsAdmin ? 0 : 1;

                var capturedUser = user;
                isAdminBox.DropDownClosed += async (s, ev) =>
                {
                    bool makeAdmin = isAdminBox.SelectedItem?.ToString() == "Admin";
                    if (makeAdmin)
                        await _userService.MakeUserAdminAsync(capturedUser.Id);
                    else
                        await _userService.RemoveAdminRoleAsync(capturedUser.Id);
                };

                var edit = new Button
                {
                    Name = $"edit{index}",
                    Text = Edit,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    BackColor = Color.FromArgb(46, 125, 50),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(90, 30),
                    Margin = new Padding(10, 10, 0, 0),
                    Cursor = Cursors.Hand
                };
                edit.FlatAppearance.BorderSize = 0;

                edit.Click += (s, ev) =>
                {
                    _editing = capturedUser;
                    LoadUserToForm(capturedUser);
                };

                var delete = new Button
                {
                    Name = $"delete{index}",
                    Text = Delete,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(90, 30),
                    Margin = new Padding(10, 10, 0, 0),
                    Cursor = Cursors.Hand
                };
                delete.FlatAppearance.BorderSize = 0;

                delete.Click += async (s, ev) =>
                {
                    var confirmResult = MessageBox.Show("Delete this user?", Confirmation, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        await _userService.DeleteUserAsync(capturedUser.Id);
                        ClearForm();
                        await RefreshUsersListAsync();
                    }
                };

                userContainer.Controls.Add(username);
                userContainer.Controls.Add(fullName);
                userContainer.Controls.Add(phone);
                userContainer.Controls.Add(isAdminBox);
                userContainer.Controls.Add(edit);
                userContainer.Controls.Add(delete);

                usersContainer.Controls.Add(userContainer);
                index++;
            }
        }

        private void LoadUserToForm(UserDataViewModel u)
        {
            txtUsername.Text  = u.Username;
            txtFirstName.Text = u.FirstName ?? "";
            txtLastName.Text  = u.LastName  ?? "";
            txtPhone.Text     = u.Phone     ?? "";
            txtAddress.Text   = u.Address   ?? "";
            btnSave.Text = "Save Changes";
            lblFormTitle.Text = "Edit User";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_editing == null) return;
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show(EmptyInputData, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var model = new EditProfileInputModel
            {
                Id        = _editing.Id,
                Username  = txtUsername.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                LastName  = txtLastName.Text.Trim(),
                Phone     = txtPhone.Text.Trim(),
                Address   = txtAddress.Text.Trim()
            };

            bool ok = await _userService.UpdateUserAsync(model);
            if (ok)
            {
                MessageBox.Show(EditSucceeded, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                await RefreshUsersListAsync();
            }
            else
            {
                MessageBox.Show(ProfileUpdateFailed, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            _editing = null;
            txtUsername.Text = txtFirstName.Text = txtLastName.Text = txtPhone.Text = txtAddress.Text = "";
            btnSave.Text = "Save Changes";
            lblFormTitle.Text = "User Details";
        }
    }
}
