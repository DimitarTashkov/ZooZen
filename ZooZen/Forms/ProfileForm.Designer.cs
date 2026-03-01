using ZooZen.Utilities;

namespace ZooZen.Forms
{
    partial class ProfileForm
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
            lblTitle = new Label();
            lblUsernameL = new Label();
            txtUsername = new TextBox();
            lblPasswordL = new Label();
            txtPassword = new TextBox();
            lblFirstNameL = new Label();
            txtFirstName = new TextBox();
            lblLastNameL = new Label();
            txtLastName = new TextBox();
            lblPhoneL = new Label();
            txtPhone = new TextBox();
            lblAddressL = new Label();
            txtAddress = new TextBox();
            btnEdit = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            picAvatar = new PictureBox();
            btnChooseAvatar = new Button();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            //
            // formPanel
            //
            formPanel.BackColor = Color.White;
            formPanel.BackgroundImage = Properties.Resources.background;
            formPanel.BackgroundImageLayout = ImageLayout.Stretch;
            formPanel.Controls.Add(lblTitle);
            formPanel.Controls.Add(lblUsernameL);
            formPanel.Controls.Add(txtUsername);
            formPanel.Controls.Add(lblPasswordL);
            formPanel.Controls.Add(txtPassword);
            formPanel.Controls.Add(lblFirstNameL);
            formPanel.Controls.Add(txtFirstName);
            formPanel.Controls.Add(lblLastNameL);
            formPanel.Controls.Add(txtLastName);
            formPanel.Controls.Add(lblPhoneL);
            formPanel.Controls.Add(txtPhone);
            formPanel.Controls.Add(lblAddressL);
            formPanel.Controls.Add(txtAddress);
            formPanel.Controls.Add(picAvatar);
            formPanel.Controls.Add(btnChooseAvatar);
            formPanel.Controls.Add(btnEdit);
            formPanel.Controls.Add(btnSave);
            formPanel.Controls.Add(btnDelete);
            formPanel.Location = new Point(0, 0);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(30, 15, 30, 15);
            formPanel.Size = new Size(914, 650);
            formPanel.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(190, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(130, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "My Profile";
            //
            // lblUsernameL
            //
            lblUsernameL.AutoSize = true;
            lblUsernameL.BackColor = Color.Transparent;
            lblUsernameL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsernameL.ForeColor = Color.White;
            lblUsernameL.Location = new Point(40, 58);
            lblUsernameL.Name = "lblUsernameL";
            lblUsernameL.Size = new Size(85, 23);
            lblUsernameL.TabIndex = 2;
            lblUsernameL.Text = "Username";
            //
            // txtUsername
            //
            txtUsername.BackColor = Color.LightGray;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(40, 83);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(420, 30);
            txtUsername.TabIndex = 3;
            //
            // lblPasswordL
            //
            lblPasswordL.AutoSize = true;
            lblPasswordL.BackColor = Color.Transparent;
            lblPasswordL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPasswordL.ForeColor = Color.White;
            lblPasswordL.Location = new Point(40, 122);
            lblPasswordL.Name = "lblPasswordL";
            lblPasswordL.Size = new Size(85, 23);
            lblPasswordL.TabIndex = 17;
            lblPasswordL.Text = "Password";
            //
            // txtPassword
            //
            txtPassword.BackColor = Color.LightGray;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(40, 147);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(420, 30);
            txtPassword.TabIndex = 18;
            //
            // lblFirstNameL
            //
            lblFirstNameL.AutoSize = true;
            lblFirstNameL.BackColor = Color.Transparent;
            lblFirstNameL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstNameL.ForeColor = Color.White;
            lblFirstNameL.Location = new Point(40, 186);
            lblFirstNameL.Name = "lblFirstNameL";
            lblFirstNameL.Size = new Size(91, 23);
            lblFirstNameL.TabIndex = 4;
            lblFirstNameL.Text = "First Name";
            //
            // txtFirstName
            //
            txtFirstName.BackColor = Color.LightGray;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.ForeColor = Color.DimGray;
            txtFirstName.Location = new Point(40, 211);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(420, 30);
            txtFirstName.TabIndex = 5;
            //
            // lblLastNameL
            //
            lblLastNameL.AutoSize = true;
            lblLastNameL.BackColor = Color.Transparent;
            lblLastNameL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastNameL.ForeColor = Color.White;
            lblLastNameL.Location = new Point(40, 250);
            lblLastNameL.Name = "lblLastNameL";
            lblLastNameL.Size = new Size(88, 23);
            lblLastNameL.TabIndex = 6;
            lblLastNameL.Text = "Last Name";
            //
            // txtLastName
            //
            txtLastName.BackColor = Color.LightGray;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.ForeColor = Color.DimGray;
            txtLastName.Location = new Point(40, 275);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(420, 30);
            txtLastName.TabIndex = 7;
            //
            // lblPhoneL
            //
            lblPhoneL.AutoSize = true;
            lblPhoneL.BackColor = Color.Transparent;
            lblPhoneL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhoneL.ForeColor = Color.White;
            lblPhoneL.Location = new Point(40, 314);
            lblPhoneL.Name = "lblPhoneL";
            lblPhoneL.Size = new Size(56, 23);
            lblPhoneL.TabIndex = 8;
            lblPhoneL.Text = "Phone";
            //
            // txtPhone
            //
            txtPhone.BackColor = Color.LightGray;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.ForeColor = Color.DimGray;
            txtPhone.Location = new Point(40, 339);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(420, 30);
            txtPhone.TabIndex = 9;
            //
            // lblAddressL
            //
            lblAddressL.AutoSize = true;
            lblAddressL.BackColor = Color.Transparent;
            lblAddressL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddressL.ForeColor = Color.White;
            lblAddressL.Location = new Point(40, 378);
            lblAddressL.Name = "lblAddressL";
            lblAddressL.Size = new Size(68, 23);
            lblAddressL.TabIndex = 10;
            lblAddressL.Text = "Address";
            //
            // txtAddress
            //
            txtAddress.BackColor = Color.LightGray;
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.ForeColor = Color.DimGray;
            txtAddress.Location = new Point(40, 403);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(420, 30);
            txtAddress.TabIndex = 11;
            //
            // picAvatar
            //
            picAvatar.BackColor = Color.FromArgb(220, 220, 220);
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(40, 450);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(90, 90);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 15;
            picAvatar.TabStop = false;
            //
            // btnChooseAvatar
            //
            btnChooseAvatar.BackColor = Color.FromArgb(46, 125, 50);
            btnChooseAvatar.ForeColor = Color.White;
            btnChooseAvatar.FlatStyle = FlatStyle.Flat;
            btnChooseAvatar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChooseAvatar.Cursor = Cursors.Hand;
            btnChooseAvatar.Location = new Point(145, 475);
            btnChooseAvatar.Name = "btnChooseAvatar";
            btnChooseAvatar.Size = new Size(150, 40);
            btnChooseAvatar.TabIndex = 16;
            btnChooseAvatar.Text = "Choose Photo";
            btnChooseAvatar.Visible = false;
            btnChooseAvatar.UseVisualStyleBackColor = false;
            btnChooseAvatar.Click += btnChooseAvatar_Click;
            //
            // btnEdit
            //
            btnEdit.BackColor = Color.LightGray;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Location = new Point(40, 555);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 42);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            //
            // btnSave
            //
            btnSave.BackColor = Color.FromArgb(46, 125, 50);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(40, 555);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 42);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            //
            // btnDelete
            //
            btnDelete.BackColor = Color.FromArgb(198, 40, 40);
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(190, 555);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 42);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete Account";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            //
            // ProfileForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 650);
            Controls.Add(formPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = IconHelper.GetAppIcon();
            MaximizeBox = false;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ZooZen - My Profile";
            Load += ProfileForm_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private Label lblTitle;
        private Label lblUsernameL;
        private TextBox txtUsername;
        private Label lblPasswordL;
        private TextBox txtPassword;
        private Label lblFirstNameL;
        private TextBox txtFirstName;
        private Label lblLastNameL;
        private TextBox txtLastName;
        private Label lblPhoneL;
        private TextBox txtPhone;
        private Label lblAddressL;
        private TextBox txtAddress;
        private Button btnEdit;
        private Button btnSave;
        private Button btnDelete;
        private PictureBox picAvatar;
        private Button btnChooseAvatar;
    }
}
