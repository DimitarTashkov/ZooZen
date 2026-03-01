using ZooZen.Utilities;

namespace ZooZen.Forms
{
    partial class OrderHistoryForm
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
            lblHeader = new Label();
            ordersContainer = new FlowLayoutPanel();
            ordersHeaders = new FlowLayoutPanel();
            dateHeader = new Label();
            customerHeader = new Label();
            totalHeader = new Label();
            statusHeader = new Label();
            actionsHeader = new Label();
            ordersContainer.SuspendLayout();
            ordersHeaders.SuspendLayout();
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
            lblHeader.Size = new Size(914, 50);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Order History";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            //
            // ordersContainer
            //
            ordersContainer.AutoScroll = true;
            ordersContainer.BackColor = Color.FromArgb(245, 248, 245);
            ordersContainer.Controls.Add(ordersHeaders);
            ordersContainer.FlowDirection = FlowDirection.TopDown;
            ordersContainer.Location = new Point(0, 50);
            ordersContainer.Name = "ordersContainer";
            ordersContainer.Size = new Size(914, 510);
            ordersContainer.TabIndex = 1;
            ordersContainer.WrapContents = false;
            //
            // ordersHeaders
            //
            ordersHeaders.BackColor = Color.FromArgb(46, 125, 50);
            ordersHeaders.Controls.Add(dateHeader);
            ordersHeaders.Controls.Add(customerHeader);
            ordersHeaders.Controls.Add(totalHeader);
            ordersHeaders.Controls.Add(statusHeader);
            ordersHeaders.Controls.Add(actionsHeader);
            ordersHeaders.Size = new Size(894, 35);
            ordersHeaders.Name = "ordersHeaders";
            ordersHeaders.TabIndex = 0;
            //
            // dateHeader
            //
            dateHeader.AutoSize = true;
            dateHeader.BackColor = Color.Transparent;
            dateHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dateHeader.ForeColor = Color.White;
            dateHeader.Margin = new Padding(10, 5, 10, 0);
            dateHeader.Name = "dateHeader";
            dateHeader.Size = new Size(90, 23);
            dateHeader.Text = "Date";
            //
            // customerHeader
            //
            customerHeader.AutoSize = true;
            customerHeader.BackColor = Color.Transparent;
            customerHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customerHeader.ForeColor = Color.White;
            customerHeader.Margin = new Padding(38, 5, 10, 0);
            customerHeader.Name = "customerHeader";
            customerHeader.Size = new Size(120, 23);
            customerHeader.Text = "Customer";
            //
            // totalHeader
            //
            totalHeader.AutoSize = true;
            totalHeader.BackColor = Color.Transparent;
            totalHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            totalHeader.ForeColor = Color.White;
            totalHeader.Margin = new Padding(40, 5, 10, 0);
            totalHeader.Name = "totalHeader";
            totalHeader.Size = new Size(60, 23);
            totalHeader.Text = "Total";
            //
            // statusHeader
            //
            statusHeader.AutoSize = true;
            statusHeader.BackColor = Color.Transparent;
            statusHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            statusHeader.ForeColor = Color.White;
            statusHeader.Margin = new Padding(45, 5, 10, 0);
            statusHeader.Name = "statusHeader";
            statusHeader.Size = new Size(60, 23);
            statusHeader.Text = "Status";
            //
            // actionsHeader
            //
            actionsHeader.AutoSize = true;
            actionsHeader.BackColor = Color.Transparent;
            actionsHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            actionsHeader.ForeColor = Color.White;
            actionsHeader.Margin = new Padding(25, 5, 10, 0);
            actionsHeader.Name = "actionsHeader";
            actionsHeader.Size = new Size(70, 23);
            actionsHeader.Text = "Actions";
            //
            // OrderHistoryForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 245);
            ClientSize = new Size(914, 560);
            Controls.Add(ordersContainer);
            Controls.Add(lblHeader);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = IconHelper.GetAppIcon();
            MaximizeBox = false;
            Name = "OrderHistoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ZooZen - Order History";
            Load += OrderHistoryForm_Load;
            ordersContainer.ResumeLayout(false);
            ordersHeaders.ResumeLayout(false);
            ordersHeaders.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeader;
        private FlowLayoutPanel ordersContainer;
        private FlowLayoutPanel ordersHeaders;
        private Label dateHeader;
        private Label customerHeader;
        private Label totalHeader;
        private Label statusHeader;
        private Label actionsHeader;
    }
}
