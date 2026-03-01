using ZooZen.Utilities;

namespace ZooZen.Forms
{
    partial class AboutUsForm
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
            picLogo = new PictureBox();
            lblTitle = new Label();
            lblDescription = new Label();
            lblMission = new Label();
            lblMissionText = new Label();
            btnClose = new Button();
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
            formPanel.Controls.Add(lblDescription);
            formPanel.Controls.Add(lblMission);
            formPanel.Controls.Add(lblMissionText);
            formPanel.Controls.Add(btnClose);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Name = "formPanel";
            formPanel.TabIndex = 0;
            //
            // picLogo
            //
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = Properties.Resources.logo;
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Location = new Point(200, 20);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(120, 120);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(150, 150);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "About ZooZen";
            //
            // lblDescription
            //
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 11F);
            lblDescription.ForeColor = Color.FromArgb(165, 214, 167);
            lblDescription.Location = new Point(40, 200);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(440, 80);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "ZooZen is your trusted pet shop management system. We provide a wide range of products including animals, food, cosmetics, and accessories for your beloved pets.";
            //
            // lblMission
            //
            lblMission.AutoSize = true;
            lblMission.BackColor = Color.Transparent;
            lblMission.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMission.ForeColor = Color.White;
            lblMission.Location = new Point(160, 290);
            lblMission.Name = "lblMission";
            lblMission.Size = new Size(150, 32);
            lblMission.TabIndex = 3;
            lblMission.Text = "Our Mission";
            //
            // lblMissionText
            //
            lblMissionText.BackColor = Color.Transparent;
            lblMissionText.Font = new Font("Segoe UI", 11F);
            lblMissionText.ForeColor = Color.FromArgb(165, 214, 167);
            lblMissionText.Location = new Point(40, 330);
            lblMissionText.Name = "lblMissionText";
            lblMissionText.Size = new Size(440, 60);
            lblMissionText.TabIndex = 4;
            lblMissionText.Text = "To bring joy to pet owners by offering quality products at affordable prices, with excellent customer service and a seamless shopping experience.";
            //
            // btnClose
            //
            btnClose.BackColor = Color.FromArgb(46, 125, 50);
            btnClose.ForeColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(180, 410);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(160, 44);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += (s, e) => Close();
            //
            // AboutUsForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 480);
            Controls.Add(formPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = IconHelper.GetAppIcon();
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutUsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ZooZen - About Us";
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblDescription;
        private Label lblMission;
        private Label lblMissionText;
        private Button btnClose;
    }
}
