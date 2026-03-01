using ZooZen.Utilities;

namespace ZooZen.Forms
{
    partial class CheckoutForm
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
            picLogo = new PictureBox();
            lblTitle = new Label();
            lblNameL = new Label();
            txtName = new TextBox();
            lblPhoneL = new Label();
            txtPhone = new TextBox();
            lblAddressL = new Label();
            txtAddress = new TextBox();
            lblPromoL = new Label();
            txtPromo = new TextBox();
            lblPromoHint = new Label();
            lblSubtotal = new Label();
            lblDiscount = new Label();
            lblFinalTotal = new Label();
            btnPay = new Button();
            btnCancel = new Button();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            //
            // formPanel
            //
            formPanel.BackColor = Color.White;
            formPanel.BackgroundImage = Properties.Resources.background;
            formPanel.BackgroundImageLayout = ImageLayout.Stretch;
            formPanel.Controls.Add(picLogo);
            formPanel.Controls.Add(lblTitle);
            formPanel.Controls.Add(lblNameL);
            formPanel.Controls.Add(txtName);
            formPanel.Controls.Add(lblPhoneL);
            formPanel.Controls.Add(txtPhone);
            formPanel.Controls.Add(lblAddressL);
            formPanel.Controls.Add(txtAddress);
            formPanel.Controls.Add(lblPromoL);
            formPanel.Controls.Add(txtPromo);
            formPanel.Controls.Add(lblPromoHint);
            formPanel.Controls.Add(lblSubtotal);
            formPanel.Controls.Add(lblDiscount);
            formPanel.Controls.Add(lblFinalTotal);
            formPanel.Controls.Add(btnPay);
            formPanel.Controls.Add(btnCancel);
            formPanel.Dock = DockStyle.None;
            formPanel.Location = new Point(0, 0);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(40, 20, 40, 20);
            formPanel.Size = new Size(914, 580);
            formPanel.TabIndex = 0;
            //
            // picLogo
            //
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = Properties.Resources.logo;
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Location = new Point(40, 16);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(52, 52);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(104, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Complete Your Order";
            //
            // lblNameL
            //
            lblNameL.AutoSize = true;
            lblNameL.BackColor = Color.Transparent;
            lblNameL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNameL.ForeColor = Color.White;
            lblNameL.Location = new Point(40, 80);
            lblNameL.Name = "lblNameL";
            lblNameL.Size = new Size(130, 20);
            lblNameL.TabIndex = 2;
            lblNameL.Text = "Customer Name *";
            //
            // txtName
            //
            txtName.BackColor = Color.LightGray;
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(40, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(480, 32);
            txtName.TabIndex = 3;
            //
            // lblPhoneL
            //
            lblPhoneL.AutoSize = true;
            lblPhoneL.BackColor = Color.Transparent;
            lblPhoneL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhoneL.ForeColor = Color.White;
            lblPhoneL.Location = new Point(40, 145);
            lblPhoneL.Name = "lblPhoneL";
            lblPhoneL.Size = new Size(62, 20);
            lblPhoneL.TabIndex = 4;
            lblPhoneL.Text = "Phone *";
            //
            // txtPhone
            //
            txtPhone.BackColor = Color.LightGray;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(40, 167);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(480, 32);
            txtPhone.TabIndex = 5;
            //
            // lblAddressL
            //
            lblAddressL.AutoSize = true;
            lblAddressL.BackColor = Color.Transparent;
            lblAddressL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddressL.ForeColor = Color.White;
            lblAddressL.Location = new Point(40, 210);
            lblAddressL.Name = "lblAddressL";
            lblAddressL.Size = new Size(148, 20);
            lblAddressL.TabIndex = 6;
            lblAddressL.Text = "Delivery Address *";
            //
            // txtAddress
            //
            txtAddress.BackColor = Color.LightGray;
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(40, 232);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(480, 32);
            txtAddress.TabIndex = 7;
            //
            // lblPromoL
            //
            lblPromoL.AutoSize = true;
            lblPromoL.BackColor = Color.Transparent;
            lblPromoL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPromoL.ForeColor = Color.White;
            lblPromoL.Location = new Point(40, 275);
            lblPromoL.Name = "lblPromoL";
            lblPromoL.Size = new Size(156, 20);
            lblPromoL.TabIndex = 8;
            lblPromoL.Text = "Promo Code (optional)";
            //
            // txtPromo
            //
            txtPromo.BackColor = Color.LightGray;
            txtPromo.Font = new Font("Segoe UI", 11F);
            txtPromo.Location = new Point(40, 297);
            txtPromo.Name = "txtPromo";
            txtPromo.Size = new Size(480, 32);
            txtPromo.TabIndex = 9;
            txtPromo.TextChanged += txtPromo_TextChanged;
            //
            // lblPromoHint
            //
            lblPromoHint.AutoSize = true;
            lblPromoHint.BackColor = Color.Transparent;
            lblPromoHint.Font = new Font("Segoe UI", 8F);
            lblPromoHint.ForeColor = Color.FromArgb(200, 200, 200);
            lblPromoHint.Location = new Point(40, 332);
            lblPromoHint.Name = "lblPromoHint";
            lblPromoHint.Size = new Size(405, 19);
            lblPromoHint.TabIndex = 10;
            lblPromoHint.Text = "Available codes: ZOOZEN10 (10%), ZOOZEN20 (20%), PETLOVER (15%)";
            //
            // lblSubtotal
            //
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.Transparent;
            lblSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSubtotal.ForeColor = Color.White;
            lblSubtotal.Location = new Point(40, 370);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(150, 28);
            lblSubtotal.TabIndex = 11;
            lblSubtotal.Text = "Subtotal: $0.00";
            //
            // lblDiscount
            //
            lblDiscount.AutoSize = true;
            lblDiscount.BackColor = Color.Transparent;
            lblDiscount.Font = new Font("Segoe UI", 11F);
            lblDiscount.ForeColor = Color.FromArgb(165, 214, 167);
            lblDiscount.Location = new Point(40, 400);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(50, 25);
            lblDiscount.TabIndex = 12;
            lblDiscount.Text = "";
            lblDiscount.Visible = false;
            //
            // lblFinalTotal
            //
            lblFinalTotal.AutoSize = true;
            lblFinalTotal.BackColor = Color.Transparent;
            lblFinalTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFinalTotal.ForeColor = Color.FromArgb(165, 214, 167);
            lblFinalTotal.Location = new Point(40, 428);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(200, 32);
            lblFinalTotal.TabIndex = 13;
            lblFinalTotal.Text = "Final Total: $0.00";
            //
            // btnPay
            //
            btnPay.BackColor = Color.FromArgb(46, 125, 50);
            btnPay.ForeColor = Color.White;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPay.Cursor = Cursors.Hand;
            btnPay.Location = new Point(40, 480);
            btnPay.Margin = new Padding(3, 4, 3, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(280, 50);
            btnPay.TabIndex = 14;
            btnPay.Text = "Pay && Generate Invoice";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            //
            // btnCancel
            //
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(340, 480);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            //
            // CheckoutForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 580);
            Controls.Add(formPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = IconHelper.GetAppIcon();
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CheckoutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ZooZen - Checkout";
            Load += CheckoutForm_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblNameL;
        private TextBox txtName;
        private Label lblPhoneL;
        private TextBox txtPhone;
        private Label lblAddressL;
        private TextBox txtAddress;
        private Label lblPromoL;
        private TextBox txtPromo;
        private Label lblPromoHint;
        private Label lblSubtotal;
        private Label lblDiscount;
        private Label lblFinalTotal;
        private Button btnPay;
        private Button btnCancel;
    }
}
