using ZooZen.DTOs.User;
using ZooZen.Models;
using ZooZen.Services.Interfaces;
using ZooZen.Utilities;
using static ZooZen.Utilities.DynamicContentTranslator.EntitiesTranslation;

namespace ZooZen.Forms
{
    /// <summary>
    /// Form for viewing and editing the user's personal profile
    /// </summary>
    public partial class ProfileForm : Form
    {
        private readonly IUserService _userService;
        private readonly Guid _userId;
        private User? _user;
        private string? _selectedAvatarPath = null;

        public ProfileForm(IUserService userService, Guid userId)
        {
            _userService = userService;
            _userId      = userId;
            InitializeComponent();

            var nav = NavigationHelper.CreateNavigationMenu(this, AuthorizationHelper.IsAuthorized());
            Controls.Add(nav);
            nav.BringToFront();

            int navHeight = nav.PreferredSize.Height;
            formPanel.Location = new Point(0, navHeight);
            formPanel.Size = new Size(ClientSize.Width, ClientSize.Height - navHeight);
            ClientSize = new Size(ClientSize.Width, ClientSize.Height + navHeight);
            formPanel.BringToFront();
        }

        private async void ProfileForm_Load(object sender, EventArgs e)
        {
            _user = await _userService.FindUserByIdAsync(_userId);
            if (_user == null) { Close(); return; }

            txtUsername.Text  = _user.Username;
            txtPassword.Text = "";
            txtFirstName.Text = _user.FirstName ?? "";
            txtLastName.Text  = _user.LastName  ?? "";
            txtPhone.Text     = _user.Phone     ?? "";
            txtAddress.Text   = _user.Address   ?? "";

            if (!string.IsNullOrEmpty(_user.ProfilePicturePath) && File.Exists(_user.ProfilePicturePath))
            {
                _selectedAvatarPath = _user.ProfilePicturePath;
                try { picAvatar.Image = Image.FromFile(_user.ProfilePicturePath); } catch { }
            }

            SetReadOnly(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetReadOnly(false);
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnChooseAvatar.Visible = true;
            txtPassword.ReadOnly = false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            { MessageBox.Show(EmptyInputData, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (string.IsNullOrEmpty(_selectedAvatarPath))
            {
                MessageBox.Show("Please choose a profile photo!", "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var model = new EditProfileInputModel
            {
                Id        = _userId,
                Username  = txtUsername.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                LastName  = txtLastName.Text.Trim(),
                Phone     = txtPhone.Text.Trim(),
                Address   = txtAddress.Text.Trim(),
                ProfilePicturePath = _selectedAvatarPath,
                Password  = string.IsNullOrWhiteSpace(txtPassword.Text) ? null : txtPassword.Text.Trim()
            };

            bool ok = await _userService.UpdateUserAsync(model);
            if (ok)
            {
                MessageBox.Show(ProfileUpdatedSuccessfully, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetReadOnly(true);
                btnSave.Visible = false;
                btnEdit.Visible = true;
                btnChooseAvatar.Visible = false;
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show(ProfileUpdateFailed, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(ProfileDeleteWarning, Confirmation, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            bool ok = await _userService.DeleteUserAsync(_userId);
            if (ok)
            {
                _userService.LogoutUser();
                MessageBox.Show(ProfileDeletionSuccessful, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Abort;
                Close();
            }
            else
            {
                MessageBox.Show(ProfileDeletionFailed, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Title = "Choose Profile Photo",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _selectedAvatarPath = dlg.FileName;
                try { picAvatar.Image = Image.FromFile(dlg.FileName); } catch { }
            }
        }

        private void SetReadOnly(bool readOnly)
        {
            txtFirstName.ReadOnly = readOnly;
            txtLastName.ReadOnly  = readOnly;
            txtPhone.ReadOnly     = readOnly;
            txtAddress.ReadOnly   = readOnly;
            txtPassword.ReadOnly  = readOnly;
            txtUsername.ReadOnly   = true;
        }
    }
}
