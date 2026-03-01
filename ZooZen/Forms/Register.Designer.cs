using ZooZen.Utilities;

namespace ZooZen.Forms
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            formPanel = new Panel();
            lblError = new Label();
            lblLogin = new Label();
            btnRegister = new Button();
            txtAddress = new TextBox();
            lblAddressL = new Label();
            txtPhone = new TextBox();
            lblPhoneL = new Label();
            txtLastName = new TextBox();
            lblLastNameL = new Label();
            txtFirstName = new TextBox();
            lblFirstNameL = new Label();
            txtPassword = new TextBox();
            lblPasswordL = new Label();
            txtUsername = new TextBox();
            lblUsernameL = new Label();
            picAvatar = new PictureBox();
            btnChooseAvatar = new Button();
            picLogo = new PictureBox();
            lblTitle = new Label();
            label1 = new Label();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = SystemColors.Control;
            formPanel.BackgroundImage = Properties.Resources.background;
            formPanel.BackgroundImageLayout = ImageLayout.Stretch;
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(lblError);
            formPanel.Controls.Add(lblLogin);
            formPanel.Controls.Add(btnRegister);
            formPanel.Controls.Add(txtAddress);
            formPanel.Controls.Add(lblAddressL);
            formPanel.Controls.Add(txtPhone);
            formPanel.Controls.Add(lblPhoneL);
            formPanel.Controls.Add(txtLastName);
            formPanel.Controls.Add(lblLastNameL);
            formPanel.Controls.Add(txtFirstName);
            formPanel.Controls.Add(lblFirstNameL);
            formPanel.Controls.Add(txtPassword);
            formPanel.Controls.Add(lblPasswordL);
            formPanel.Controls.Add(txtUsername);
            formPanel.Controls.Add(lblUsernameL);
            formPanel.Controls.Add(picAvatar);
            formPanel.Controls.Add(btnChooseAvatar);
            formPanel.Controls.Add(picLogo);
            formPanel.Controls.Add(lblTitle);
            formPanel.Location = new Point(81, 33);
            formPanel.Margin = new Padding(3, 4, 3, 4);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(753, 610);
            formPanel.TabIndex = 1;
            formPanel.Paint += pnlBackground_Paint;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(131, 560);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 17);
            lblError.TabIndex = 19;
            lblError.Visible = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Cursor = Cursors.Hand;
            lblLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(0, 563);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(303, 25);
            lblLogin.TabIndex = 18;
            lblLogin.Text = "Already have an account? Sign in";
            lblLogin.Click += lblLogin_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(46, 125, 50);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(507, 504);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(183, 55);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.LightGray;
            txtAddress.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            txtAddress.ForeColor = Color.DimGray;
            txtAddress.Location = new Point(400, 359);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(278, 27);
            txtAddress.TabIndex = 14;
            // 
            // lblAddressL
            // 
            lblAddressL.AutoSize = true;
            lblAddressL.BackColor = Color.Transparent;
            lblAddressL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblAddressL.ForeColor = Color.White;
            lblAddressL.Location = new Point(482, 321);
            lblAddressL.Name = "lblAddressL";
            lblAddressL.Size = new Size(106, 32);
            lblAddressL.TabIndex = 13;
            lblAddressL.Text = "Address";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.LightGray;
            txtPhone.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            txtPhone.ForeColor = Color.DimGray;
            txtPhone.Location = new Point(400, 267);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(278, 27);
            txtPhone.TabIndex = 12;
            // 
            // lblPhoneL
            // 
            lblPhoneL.AutoSize = true;
            lblPhoneL.BackColor = Color.Transparent;
            lblPhoneL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblPhoneL.ForeColor = Color.White;
            lblPhoneL.Location = new Point(490, 229);
            lblPhoneL.Name = "lblPhoneL";
            lblPhoneL.Size = new Size(86, 32);
            lblPhoneL.TabIndex = 11;
            lblPhoneL.Text = "Phone";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.LightGray;
            txtLastName.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            txtLastName.ForeColor = Color.DimGray;
            txtLastName.Location = new Point(131, 359);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(278, 27);
            txtLastName.TabIndex = 10;
            // 
            // lblLastNameL
            // 
            lblLastNameL.AutoSize = true;
            lblLastNameL.BackColor = Color.Transparent;
            lblLastNameL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblLastNameL.ForeColor = Color.White;
            lblLastNameL.Location = new Point(195, 321);
            lblLastNameL.Name = "lblLastNameL";
            lblLastNameL.Size = new Size(133, 32);
            lblLastNameL.TabIndex = 9;
            lblLastNameL.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.LightGray;
            txtFirstName.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            txtFirstName.ForeColor = Color.DimGray;
            txtFirstName.Location = new Point(131, 267);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(278, 27);
            txtFirstName.TabIndex = 8;
            // 
            // lblFirstNameL
            // 
            lblFirstNameL.AutoSize = true;
            lblFirstNameL.BackColor = Color.Transparent;
            lblFirstNameL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblFirstNameL.ForeColor = Color.White;
            lblFirstNameL.Location = new Point(195, 229);
            lblFirstNameL.Name = "lblFirstNameL";
            lblFirstNameL.Size = new Size(137, 32);
            lblFirstNameL.TabIndex = 7;
            lblFirstNameL.Text = "First Name";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.LightGray;
            txtPassword.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(131, 176);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(278, 27);
            txtPassword.TabIndex = 6;
            // 
            // lblPasswordL
            // 
            lblPasswordL.AutoSize = true;
            lblPasswordL.BackColor = Color.Transparent;
            lblPasswordL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblPasswordL.ForeColor = Color.White;
            lblPasswordL.Location = new Point(195, 139);
            lblPasswordL.Name = "lblPasswordL";
            lblPasswordL.Size = new Size(133, 32);
            lblPasswordL.TabIndex = 5;
            lblPasswordL.Text = "*Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.LightGray;
            txtUsername.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(131, 85);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(278, 27);
            txtUsername.TabIndex = 4;
            // 
            // lblUsernameL
            // 
            lblUsernameL.AutoSize = true;
            lblUsernameL.BackColor = Color.Transparent;
            lblUsernameL.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblUsernameL.ForeColor = Color.White;
            lblUsernameL.Location = new Point(195, 48);
            lblUsernameL.Name = "lblUsernameL";
            lblUsernameL.Size = new Size(139, 32);
            lblUsernameL.TabIndex = 3;
            lblUsernameL.Text = "*Username";
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.FromArgb(220, 220, 220);
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(131, 424);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(90, 90);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 20;
            picAvatar.TabStop = false;
            // 
            // btnChooseAvatar
            // 
            btnChooseAvatar.BackColor = Color.FromArgb(46, 125, 50);
            btnChooseAvatar.Cursor = Cursors.Hand;
            btnChooseAvatar.FlatStyle = FlatStyle.Flat;
            btnChooseAvatar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnChooseAvatar.ForeColor = Color.White;
            btnChooseAvatar.Location = new Point(235, 449);
            btnChooseAvatar.Name = "btnChooseAvatar";
            btnChooseAvatar.Size = new Size(150, 40);
            btnChooseAvatar.TabIndex = 21;
            btnChooseAvatar.Text = "Choose Photo";
            btnChooseAvatar.UseVisualStyleBackColor = false;
            btnChooseAvatar.Click += btnChooseAvatar_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = Properties.Resources.logo;
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Location = new Point(-13, -32);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(184, 213);
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(261, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Register - ZooZen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(32, 530);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 22;
            label1.Text = "Return to login";
            label1.Click += label1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(formPanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZooZen - Register";
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private Label lblError;
        private Label lblLogin;
        private Button btnRegister;
        private TextBox txtAddress;
        private Label lblAddressL;
        private TextBox txtPhone;
        private Label lblPhoneL;
        private TextBox txtLastName;
        private Label lblLastNameL;
        private TextBox txtFirstName;
        private Label lblFirstNameL;
        private TextBox txtPassword;
        private Label lblPasswordL;
        private TextBox txtUsername;
        private Label lblUsernameL;
        private PictureBox picLogo;
        private Label lblTitle;
        private PictureBox picAvatar;
        private Button btnChooseAvatar;
        private Label label1;
    }
}
