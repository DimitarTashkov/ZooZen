using ZooZen.Utilities;

namespace ZooZen.Forms
{
    partial class AdminUsersForm
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
            usersContainer = new FlowLayoutPanel();
            usersHeaders = new FlowLayoutPanel();
            usernameHeader = new Label();
            fullNameHeader = new Label();
            phoneHeader = new Label();
            addressHeader = new Label();
            roleHeader = new Label();
            pnlRight = new Panel();
            lblFormTitle = new Label();
            lblUsernameL = new Label();
            txtUsername = new TextBox();
            lblFirstNameL = new Label();
            txtFirstName = new TextBox();
            lblLastNameL = new Label();
            txtLastName = new TextBox();
            lblPhoneL = new Label();
            txtPhone = new TextBox();
            lblAddressL = new Label();
            txtAddress = new TextBox();
            btnSave = new Button();
            lblHeader = new Label();
            usersContainer.SuspendLayout();
            usersHeaders.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();
            //
            // lblHeader
            //
            lblHeader.BackColor = Color.FromArgb(27, 68, 30);
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Padding = new Padding(20, 0, 0, 0);
            lblHeader.Size = new Size(1060, 50);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "User Management";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            //
            // usersContainer
            //
            usersContainer.AutoScroll = true;
            usersContainer.BackColor = Color.FromArgb(245, 248, 245);
            usersContainer.Controls.Add(usersHeaders);
            usersContainer.FlowDirection = FlowDirection.TopDown;
            usersContainer.Location = new Point(0, 50);
            usersContainer.Name = "usersContainer";
            usersContainer.Size = new Size(720, 610);
            usersContainer.TabIndex = 1;
            usersContainer.WrapContents = false;
            //
            // usersHeaders
            //
            usersHeaders.BackColor = Color.FromArgb(46, 125, 50);
            usersHeaders.Controls.Add(usernameHeader);
            usersHeaders.Controls.Add(fullNameHeader);
            usersHeaders.Controls.Add(phoneHeader);
            usersHeaders.Controls.Add(addressHeader);
            usersHeaders.Controls.Add(roleHeader);
            usersHeaders.Size = new Size(700, 35);
            usersHeaders.Name = "usersHeaders";
            usersHeaders.TabIndex = 0;
            //
            // usernameHeader
            //
            usernameHeader.AutoSize = false;
            usernameHeader.BackColor = Color.Transparent;
            usernameHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            usernameHeader.ForeColor = Color.White;
            usernameHeader.Margin = new Padding(10, 5, 0, 0);
            usernameHeader.Name = "usernameHeader";
            usernameHeader.Size = new Size(120, 25);
            usernameHeader.Text = "Username";
            usernameHeader.TextAlign = ContentAlignment.MiddleLeft;
            //
            // fullNameHeader
            //
            fullNameHeader.AutoSize = false;
            fullNameHeader.BackColor = Color.Transparent;
            fullNameHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            fullNameHeader.ForeColor = Color.White;
            fullNameHeader.Margin = new Padding(10, 5, 0, 0);
            fullNameHeader.Name = "fullNameHeader";
            fullNameHeader.Size = new Size(130, 25);
            fullNameHeader.Text = "Full Name";
            fullNameHeader.TextAlign = ContentAlignment.MiddleLeft;
            //
            // phoneHeader
            //
            phoneHeader.AutoSize = false;
            phoneHeader.BackColor = Color.Transparent;
            phoneHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            phoneHeader.ForeColor = Color.White;
            phoneHeader.Margin = new Padding(10, 5, 0, 0);
            phoneHeader.Name = "phoneHeader";
            phoneHeader.Size = new Size(110, 25);
            phoneHeader.Text = "Phone";
            phoneHeader.TextAlign = ContentAlignment.MiddleLeft;
            //
            // addressHeader (repurposed as "Role" column header label, kept as-is)
            //
            addressHeader.AutoSize = false;
            addressHeader.BackColor = Color.Transparent;
            addressHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addressHeader.ForeColor = Color.White;
            addressHeader.Margin = new Padding(10, 5, 0, 0);
            addressHeader.Name = "addressHeader";
            addressHeader.Size = new Size(90, 25);
            addressHeader.Text = "Role";
            addressHeader.TextAlign = ContentAlignment.MiddleLeft;
            //
            // roleHeader (actions column)
            //
            roleHeader.AutoSize = false;
            roleHeader.BackColor = Color.Transparent;
            roleHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            roleHeader.ForeColor = Color.White;
            roleHeader.Margin = new Padding(10, 5, 0, 0);
            roleHeader.Name = "roleHeader";
            roleHeader.Size = new Size(190, 25);
            roleHeader.Text = "Actions";
            roleHeader.TextAlign = ContentAlignment.MiddleLeft;
            //
            // pnlRight
            //
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(lblFormTitle);
            pnlRight.Controls.Add(lblUsernameL);
            pnlRight.Controls.Add(txtUsername);
            pnlRight.Controls.Add(lblFirstNameL);
            pnlRight.Controls.Add(txtFirstName);
            pnlRight.Controls.Add(lblLastNameL);
            pnlRight.Controls.Add(txtLastName);
            pnlRight.Controls.Add(lblPhoneL);
            pnlRight.Controls.Add(txtPhone);
            pnlRight.Controls.Add(lblAddressL);
            pnlRight.Controls.Add(txtAddress);
            pnlRight.Controls.Add(btnSave);
            pnlRight.Location = new Point(720, 50);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(340, 610);
            pnlRight.TabIndex = 2;
            //
            // lblFormTitle
            //
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblFormTitle.Location = new Point(20, 12);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(120, 28);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "User Details";
            //
            // lblUsernameL
            //
            lblUsernameL.AutoSize = true;
            lblUsernameL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsernameL.ForeColor = Color.FromArgb(33, 33, 33);
            lblUsernameL.Location = new Point(20, 50);
            lblUsernameL.Name = "lblUsernameL";
            lblUsernameL.Size = new Size(75, 20);
            lblUsernameL.TabIndex = 1;
            lblUsernameL.Text = "Username";
            //
            // txtUsername
            //
            txtUsername.BackColor = Color.LightGray;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(20, 72);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 30);
            txtUsername.TabIndex = 2;
            //
            // lblFirstNameL
            //
            lblFirstNameL.AutoSize = true;
            lblFirstNameL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFirstNameL.ForeColor = Color.FromArgb(33, 33, 33);
            lblFirstNameL.Location = new Point(20, 115);
            lblFirstNameL.Name = "lblFirstNameL";
            lblFirstNameL.Size = new Size(80, 20);
            lblFirstNameL.TabIndex = 3;
            lblFirstNameL.Text = "First Name";
            //
            // txtFirstName
            //
            txtFirstName.BackColor = Color.LightGray;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(20, 137);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(270, 30);
            txtFirstName.TabIndex = 4;
            //
            // lblLastNameL
            //
            lblLastNameL.AutoSize = true;
            lblLastNameL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLastNameL.ForeColor = Color.FromArgb(33, 33, 33);
            lblLastNameL.Location = new Point(20, 180);
            lblLastNameL.Name = "lblLastNameL";
            lblLastNameL.Size = new Size(78, 20);
            lblLastNameL.TabIndex = 5;
            lblLastNameL.Text = "Last Name";
            //
            // txtLastName
            //
            txtLastName.BackColor = Color.LightGray;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(20, 202);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(270, 30);
            txtLastName.TabIndex = 6;
            //
            // lblPhoneL
            //
            lblPhoneL.AutoSize = true;
            lblPhoneL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhoneL.ForeColor = Color.FromArgb(33, 33, 33);
            lblPhoneL.Location = new Point(20, 245);
            lblPhoneL.Name = "lblPhoneL";
            lblPhoneL.Size = new Size(49, 20);
            lblPhoneL.TabIndex = 7;
            lblPhoneL.Text = "Phone";
            //
            // txtPhone
            //
            txtPhone.BackColor = Color.LightGray;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(20, 267);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(270, 30);
            txtPhone.TabIndex = 8;
            //
            // lblAddressL
            //
            lblAddressL.AutoSize = true;
            lblAddressL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddressL.ForeColor = Color.FromArgb(33, 33, 33);
            lblAddressL.Location = new Point(20, 310);
            lblAddressL.Name = "lblAddressL";
            lblAddressL.Size = new Size(60, 20);
            lblAddressL.TabIndex = 9;
            lblAddressL.Text = "Address";
            //
            // txtAddress
            //
            txtAddress.BackColor = Color.LightGray;
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(20, 332);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(270, 30);
            txtAddress.TabIndex = 10;
            //
            // btnSave
            //
            btnSave.BackColor = Color.FromArgb(46, 125, 50);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(20, 385);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(220, 44);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // AdminUsersForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 245);
            ClientSize = new Size(1060, 660);
            Controls.Add(pnlRight);
            Controls.Add(usersContainer);
            Controls.Add(lblHeader);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = IconHelper.GetAppIcon();
            MaximizeBox = false;
            Name = "AdminUsersForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ZooZen - User Management";
            Load += AdminUsersForm_Load;
            usersContainer.ResumeLayout(false);
            usersHeaders.ResumeLayout(false);
            usersHeaders.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeader;
        private FlowLayoutPanel usersContainer;
        private FlowLayoutPanel usersHeaders;
        private Label usernameHeader;
        private Label fullNameHeader;
        private Label phoneHeader;
        private Label addressHeader;
        private Label roleHeader;
        private Panel pnlRight;
        private Label lblFormTitle;
        private Label lblUsernameL;
        private TextBox txtUsername;
        private Label lblFirstNameL;
        private TextBox txtFirstName;
        private Label lblLastNameL;
        private TextBox txtLastName;
        private Label lblPhoneL;
        private TextBox txtPhone;
        private Label lblAddressL;
        private TextBox txtAddress;
        private Button btnSave;
    }
}
