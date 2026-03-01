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

        public ProfileForm(IUserService userService, Guid userId)
        {
            _userService = userService;
            _userId      = userId;
            InitializeComponent();

            var nav = NavigationHelper.CreateNavigationMenu(this, AuthorizationHelper.IsAuthorized());
            Controls.Add(nav);
            nav.BringToFront();
            formPanel.BringToFront();
        }

        private async void ProfileForm_Load(object sender, EventArgs e)
        {
            _user = await _userService.FindUserByIdAsync(_userId);
            if (_user == null) { Close(); return; }

            txtUsername.Text  = _user.Username;
            txtFirstName.Text = _user.FirstName ?? "";
            txtLastName.Text  = _user.LastName  ?? "";
            txtPhone.Text     = _user.Phone     ?? "";
            txtAddress.Text   = _user.Address   ?? "";

            // Set fields to read-only initially
            SetReadOnly(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetReadOnly(false);
            btnSave.Visible = true;
            btnEdit.Visible = false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            { MessageBox.Show(EmptyInputData, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            var model = new EditProfileInputModel
            {
                Id        = _userId,
                Username  = txtUsername.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                LastName  = txtLastName.Text.Trim(),
                Phone     = txtPhone.Text.Trim(),
                Address   = txtAddress.Text.Trim()
            };

            bool ok = await _userService.UpdateUserAsync(model);
            if (ok)
            {
                MessageBox.Show(ProfileUpdatedSuccessfully, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetReadOnly(true);
                btnSave.Visible = false;
                btnEdit.Visible = true;
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

        private void SetReadOnly(bool readOnly)
        {
            txtFirstName.ReadOnly = readOnly;
            txtLastName.ReadOnly  = readOnly;
            txtPhone.ReadOnly     = readOnly;
            txtAddress.ReadOnly   = readOnly;
            // Username is always read-only
            txtUsername.ReadOnly  = true;
        }
    }
}
