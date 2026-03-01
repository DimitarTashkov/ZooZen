using ZooZen.DTOs.User;
using ZooZen.Models.DbConfiguration;
using ZooZen.Services.Interfaces;
using ZooZen.Utilities;
using ZooZen.Common.Constants;
using static ZooZen.Common.Constants.ValidationConstants.UserConstants;
using static ZooZen.Utilities.DynamicContentTranslator.EntitiesTranslation;

namespace ZooZen.Forms
{
    /// <summary>
    /// Login form for ZooZen
    /// </summary>
    public partial class Login : Form
    {
        private readonly IUserService _userService;

        public Login(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            // Seed admin account on first startup
            await SeedAdmin.SeedAdminUserAsync();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate fields
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError(lblError, EmptyInputData);
                return;
            }

            lblError.Visible = false;

            var model = new LoginUserInputModel
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            var (isValid, errors) = await _userService.ValidateModelAsync(model);
            if (!isValid)
            {
                ShowError(lblError, string.Format(FieldLength, Username, NameMinLength));
                return;
            }

            bool authenticated = await _userService.AuthenticateUserAsync(model.Username, model.Password);
            if (!authenticated)
            {
                ShowError(lblError, InvalidUserCredentials);
                return;
            }

            // Initialize authorization status
            await AuthorizationHelper.InitializeAuthorizationStatusAsync(_userService);

            // Open the main form
            var mainForm = new MainForm(_userService);
            Program.SwitchMainForm(mainForm);
        }

        private void lblRegister_LinkClicked(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new Register(_userService));
        }

        private void ShowError(Label lbl, string message)
        {
            lbl.Text = message;
            lbl.Visible = true;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void pnlBackground_Paint(object sender, PaintEventArgs e)
        {
            LayoutHelper.set_ImageBackground(sender, e);
        }
    }
}
