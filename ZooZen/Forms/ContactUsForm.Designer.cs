using ZooZen.Utilities;

namespace ZooZen.Forms
{
    partial class ContactUsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            formPanel = new Panel();
            lblTitle = new Label();
            lblEmail = new Label();
            lblEmailVal = new Label();
            lblPhone = new Label();
            lblPhoneVal = new Label();
            lblAddress = new Label();
            lblAddressVal = new Label();
            lblHours = new Label();
            lblHoursVal = new Label();
            btnClose = new Button();
            formPanel.SuspendLayout();
            SuspendLayout();
            //
            // formPanel
            //
            formPanel.BackColor = Color.White;
            formPanel.BackgroundImage = Properties.Resources.background;
            formPanel.BackgroundImageLayout = ImageLayout.Stretch;
            formPanel.Controls.Add(lblTitle);
            formPanel.Controls.Add(lblEmail);
            formPanel.Controls.Add(lblEmailVal);
            formPanel.Controls.Add(lblPhone);
            formPanel.Controls.Add(lblPhoneVal);
            formPanel.Controls.Add(lblAddress);
            formPanel.Controls.Add(lblAddressVal);
            formPanel.Controls.Add(lblHours);
            formPanel.Controls.Add(lblHoursVal);
            formPanel.Controls.Add(btnClose);
            formPanel.Dock = DockStyle.None;
            formPanel.Location = new Point(0, 0);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(914, 510);
            formPanel.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(150, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Contact Us";
            //
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(40, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 28);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "\U0001f4e7  Email:";
            //
            // lblEmailVal
            //
            lblEmailVal.AutoSize = true;
            lblEmailVal.BackColor = Color.Transparent;
            lblEmailVal.Font = new Font("Segoe UI", 11F);
            lblEmailVal.ForeColor = Color.FromArgb(165, 214, 167);
            lblEmailVal.Location = new Point(60, 130);
            lblEmailVal.Name = "lblEmailVal";
            lblEmailVal.Size = new Size(180, 25);
            lblEmailVal.TabIndex = 2;
            lblEmailVal.Text = "support@zoozen.com";
            //
            // lblPhone
            //
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(40, 175);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(70, 28);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "\U0001f4de  Phone:";
            //
            // lblPhoneVal
            //
            lblPhoneVal.AutoSize = true;
            lblPhoneVal.BackColor = Color.Transparent;
            lblPhoneVal.Font = new Font("Segoe UI", 11F);
            lblPhoneVal.ForeColor = Color.FromArgb(165, 214, 167);
            lblPhoneVal.Location = new Point(60, 205);
            lblPhoneVal.Name = "lblPhoneVal";
            lblPhoneVal.Size = new Size(150, 25);
            lblPhoneVal.TabIndex = 4;
            lblPhoneVal.Text = "+359 888 123 456";
            //
            // lblAddress
            //
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(40, 250);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(80, 28);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "\U0001f4cd  Address:";
            //
            // lblAddressVal
            //
            lblAddressVal.BackColor = Color.Transparent;
            lblAddressVal.Font = new Font("Segoe UI", 11F);
            lblAddressVal.ForeColor = Color.FromArgb(165, 214, 167);
            lblAddressVal.Location = new Point(60, 280);
            lblAddressVal.Name = "lblAddressVal";
            lblAddressVal.Size = new Size(400, 50);
            lblAddressVal.TabIndex = 6;
            lblAddressVal.Text = "123 Pet Street, Sofia 1000, Bulgaria";
            //
            // lblHours
            //
            lblHours.AutoSize = true;
            lblHours.BackColor = Color.Transparent;
            lblHours.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHours.ForeColor = Color.White;
            lblHours.Location = new Point(40, 340);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(130, 28);
            lblHours.TabIndex = 7;
            lblHours.Text = "\U0001f552  Working Hours:";
            //
            // lblHoursVal
            //
            lblHoursVal.BackColor = Color.Transparent;
            lblHoursVal.Font = new Font("Segoe UI", 11F);
            lblHoursVal.ForeColor = Color.FromArgb(165, 214, 167);
            lblHoursVal.Location = new Point(60, 370);
            lblHoursVal.Name = "lblHoursVal";
            lblHoursVal.Size = new Size(400, 50);
            lblHoursVal.TabIndex = 8;
            lblHoursVal.Text = "Mon - Sat: 9:00 AM - 8:00 PM\r\nSun: 10:00 AM - 6:00 PM";
            //
            // btnClose
            //
            btnClose.BackColor = Color.FromArgb(46, 125, 50);
            btnClose.ForeColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(180, 440);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(160, 44);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += (s, e) => Close();
            //
            // ContactUsForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(formPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = IconHelper.GetAppIcon();
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ContactUsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ZooZen - Contact Us";
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private Label lblTitle;
        private Label lblEmail;
        private Label lblEmailVal;
        private Label lblPhone;
        private Label lblPhoneVal;
        private Label lblAddress;
        private Label lblAddressVal;
        private Label lblHours;
        private Label lblHoursVal;
        private Button btnClose;
    }
}
