using ZooZen.DTOs.User;
using ZooZen.Services.Interfaces;
using ZooZen.Utilities;
using ZooZen.Common.Constants;
using static ZooZen.Common.Constants.ValidationConstants.UserConstants;
using static ZooZen.Utilities.DynamicContentTranslator.EntitiesTranslation;

namespace ZooZen.Forms
{
    /// <summary>
    /// Registration form for new users in ZooZen
    /// </summary>
    public partial class Register : Form
    {
        private readonly IUserService _userService;

        public Register(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            // Required fields: username and password
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError(EmptyInputData);
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Check if username is already taken
            if (await _userService.IsUsernameTaken(username))
            {
                ShowError(UsernameExists);
                return;
            }

            var model = new RegisterUserInputModel
            {
                Username  = username,
                Password  = password,
                FirstName = txtFirstName.Text.Trim(),
                LastName  = txtLastName.Text.Trim(),
                Phone     = txtPhone.Text.Trim(),
                Address   = txtAddress.Text.Trim()
            };

            var (isValid, errors) = await _userService.ValidateModelAsync(model);
            if (!isValid)
            {
                var error = errors.First();
                ShowError(string.Format(FieldLength, error.MemberNames.FirstOrDefault(), NameMinLength));
                return;
            }

            await _userService.RegisterUserAsync(model);
            MessageBox.Show(ProfileRegistered, Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.SwitchMainForm(new Login(_userService));
        }

        private void lblLogin_LinkClicked(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new Login(_userService));
        }

        private void ShowError(string message)
        {
            lblError.Text    = message;
            lblError.Visible = true;
        }

        private void pnlBackground_Paint(object sender, PaintEventArgs e)
        {
            LayoutHelper.set_ImageBackground(sender, e);
        }
    }
}
