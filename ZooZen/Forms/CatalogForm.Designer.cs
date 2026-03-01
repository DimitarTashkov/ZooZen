using ZooZen.Utilities;

namespace ZooZen.Forms
{
    partial class CatalogForm
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
            pnlFilter = new Panel();
            lblCatL = new Label();
            cmbCategory = new ComboBox();
            lblSearchL = new Label();
            txtSearch = new TextBox();
            flpProducts = new FlowLayoutPanel();
            pnlFilter.SuspendLayout();
            SuspendLayout();
            //
            // pnlFilter
            //
            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(lblCatL);
            pnlFilter.Controls.Add(cmbCategory);
            pnlFilter.Controls.Add(lblSearchL);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 0);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1180, 52);
            pnlFilter.TabIndex = 1;
            //
            // lblCatL
            //
            lblCatL.AutoSize = true;
            lblCatL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCatL.ForeColor = Color.FromArgb(33, 33, 33);
            lblCatL.Location = new Point(16, 16);
            lblCatL.Name = "lblCatL";
            lblCatL.Size = new Size(72, 20);
            lblCatL.TabIndex = 0;
            lblCatL.Text = "Category:";
            //
            // cmbCategory
            //
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.Location = new Point(92, 12);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(160, 31);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            //
            // lblSearchL
            //
            lblSearchL.AutoSize = true;
            lblSearchL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearchL.ForeColor = Color.FromArgb(33, 33, 33);
            lblSearchL.Location = new Point(268, 16);
            lblSearchL.Name = "lblSearchL";
            lblSearchL.Size = new Size(56, 20);
            lblSearchL.TabIndex = 2;
            lblSearchL.Text = "Search:";
            //
            // txtSearch
            //
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(336, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter product name...";
            txtSearch.Size = new Size(280, 30);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            //
            // flpProducts
            //
            flpProducts.AutoScroll = true;
            flpProducts.BackColor = Color.FromArgb(245, 248, 245);
            flpProducts.Dock = DockStyle.Fill;
            flpProducts.Location = new Point(0, 52);
            flpProducts.Name = "flpProducts";
            flpProducts.Padding = new Padding(10);
            flpProducts.Size = new Size(1180, 688);
            flpProducts.TabIndex = 2;
            flpProducts.WrapContents = true;
            //
            // CatalogForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 740);
            Controls.Add(flpProducts);
            Controls.Add(pnlFilter);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Sizable;
            Icon = IconHelper.GetAppIcon();
            MinimumSize = new Size(900, 600);
            Name = "CatalogForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ZooZen - Catalog";
            Load += CatalogForm_Load;
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFilter;
        private Label lblCatL;
        private ComboBox cmbCategory;
        private Label lblSearchL;
        private TextBox txtSearch;
        private FlowLayoutPanel flpProducts;
    }
}
