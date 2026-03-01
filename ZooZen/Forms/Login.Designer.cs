using ZooZen.Utilities;

namespace ZooZen.Forms
{
    partial class Login
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
            formPanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblError = new Label();
            lblRegister = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPasswordL = new Label();
            txtUsername = new TextBox();
            lblUsernameL = new Label();
            picLogo = new PictureBox();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            //
            // formPanel
            //
            formPanel.BackColor = Color.White;
            formPanel.BackgroundImage = Properties.Resources.background;
            formPanel.BackgroundImageLayout = ImageLayout.Stretch;
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(label2);
            formPanel.Controls.Add(label3);
            formPanel.Controls.Add(lblError);
            formPanel.Controls.Add(lblRegister);
            formPanel.Controls.Add(btnLogin);
            formPanel.Controls.Add(txtPassword);
            formPanel.Controls.Add(lblPasswordL);
            formPanel.Controls.Add(txtUsername);
            formPanel.Controls.Add(lblUsernameL);
            formPanel.Controls.Add(picLogo);
            formPanel.Location = new Point(57, 72);
            formPanel.Margin = new Padding(3, 4, 3, 4);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(800, 467);
            formPanel.TabIndex = 1;
            formPanel.Paint += pnlBackground_Paint;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 11);
            label1.Name = "label1";
            label1.Size = new Size(300, 41);
            label1.TabIndex = 9;
            label1.Text = "Welcome to ZooZen";
            //
            // label2
            //
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(165, 214, 167);
            label2.Location = new Point(30, 70);
            label2.MaximumSize = new Size(360, 0);
            label2.Name = "label2";
            label2.Size = new Size(360, 50);
            label2.TabIndex = 10;
            label2.Text = "\U0001f43e Your trusted pet shop management system — everything your pet needs, all in one place.";
            //
            // label3
            //
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(200, 230, 201);
            label3.Location = new Point(30, 140);
            label3.MaximumSize = new Size(360, 0);
            label3.Name = "label3";
            label3.Size = new Size(360, 220);
            label3.TabIndex = 11;
            label3.Text = "\u2705 Browse our catalog of animals, food, cosmetics & accessories\r\n\r\n\U0001f6d2 Add products to your cart and checkout with promo codes\r\n\r\n\U0001f4cb View your order history and download invoices\r\n\r\n\U0001f464 Manage your personal profile anytime\r\n\r\n\U0001f512 Sign in to get started!";
            //
            // lblError
            //
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(400, 303);
            lblError.Name = "lblError";
            lblError.Size = new Size(54, 17);
            lblError.TabIndex = 8;
            lblError.Text = "";
            lblError.Visible = false;
            //
            // lblRegister
            //
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.Transparent;
            lblRegister.Cursor = Cursors.Hand;
            lblRegister.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblRegister.ForeColor = Color.Blue;
            lblRegister.Location = new Point(560, 420);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(81, 25);
            lblRegister.TabIndex = 6;
            lblRegister.Text = "Register";
            lblRegister.Click += lblRegister_LinkClicked;
            //
            // btnLogin
            //
            btnLogin.BackColor = Color.FromArgb(46, 125, 50);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(503, 347);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(183, 55);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            //
            // txtPassword
            //
            txtPassword.BackColor = Color.LightGray;
            txtPassword.Font = new Font("Verdana", 12F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(400, 263);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(395, 32);
            txtPassword.TabIndex = 4;
            txtPassword.Enter += txtPassword_Enter;
            //
            // lblPasswordL
            //
            lblPasswordL.AutoSize = true;
            lblPasswordL.BackColor = Color.Transparent;
            lblPasswordL.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblPasswordL.ForeColor = Color.White;
            lblPasswordL.Location = new Point(543, 219);
            lblPasswordL.Name = "lblPasswordL";
            lblPasswordL.Size = new Size(132, 37);
            lblPasswordL.TabIndex = 3;
            lblPasswordL.Text = "Password";
            //
            // txtUsername
            //
            txtUsername.BackColor = Color.LightGray;
            txtUsername.Font = new Font("Verdana", 12F);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(400, 153);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(395, 32);
            txtUsername.TabIndex = 2;
            txtUsername.Enter += txtUsername_Enter;
            //
            // lblUsernameL
            //
            lblUsernameL.AutoSize = true;
            lblUsernameL.BackColor = Color.Transparent;
            lblUsernameL.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblUsernameL.ForeColor = Color.White;
            lblUsernameL.Location = new Point(535, 112);
            lblUsernameL.Name = "lblUsernameL";
            lblUsernameL.Size = new Size(140, 37);
            lblUsernameL.TabIndex = 1;
            lblUsernameL.Text = "Username";
            //
            // picLogo
            //
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = Properties.Resources.logo;
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Location = new Point(614, -59);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(231, 228);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            //
            // Login
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(formPanel);
            DoubleBuffered = true;
            Icon = IconHelper.GetAppIcon();
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZooZen - Sign In";
            Load += Login_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblError;
        private Label lblRegister;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblPasswordL;
        private TextBox txtUsername;
        private Label lblUsernameL;
        private PictureBox picLogo;
    }
}
