using ZooZen.Utilities;

namespace ZooZen.Forms
{
    partial class AdminProductsForm
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
            productsContainer = new FlowLayoutPanel();
            productsHeaders = new FlowLayoutPanel();
            nameHeader = new Label();
            categoryHeader = new Label();
            priceHeader = new Label();
            stockHeader = new Label();
            pnlRight = new Panel();
            lblFormTitle = new Label();
            lblNameL = new Label();
            txtName = new TextBox();
            lblDescriptionL = new Label();
            txtDescription = new TextBox();
            lblCategoryL = new Label();
            cmbCategory = new ComboBox();
            lblPriceL = new Label();
            txtPrice = new TextBox();
            lblStockL = new Label();
            txtStock = new TextBox();
            lblImageL = new Label();
            picProductImage = new PictureBox();
            btnChooseImage = new Button();
            btnSave = new Button();
            btnNew = new Button();
            lblHeader = new Label();
            productsContainer.SuspendLayout();
            productsHeaders.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
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
            lblHeader.Size = new Size(1100, 50);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Product Management";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            //
            // productsContainer
            //
            productsContainer.AutoScroll = true;
            productsContainer.BackColor = Color.FromArgb(245, 248, 245);
            productsContainer.Controls.Add(productsHeaders);
            productsContainer.FlowDirection = FlowDirection.TopDown;
            productsContainer.Location = new Point(0, 50);
            productsContainer.Name = "productsContainer";
            productsContainer.Size = new Size(700, 630);
            productsContainer.TabIndex = 1;
            productsContainer.WrapContents = false;
            //
            // productsHeaders
            //
            productsHeaders.BackColor = Color.FromArgb(46, 125, 50);
            productsHeaders.Controls.Add(nameHeader);
            productsHeaders.Controls.Add(categoryHeader);
            productsHeaders.Controls.Add(priceHeader);
            productsHeaders.Controls.Add(stockHeader);
            productsHeaders.Size = new Size(680, 35);
            productsHeaders.Name = "productsHeaders";
            productsHeaders.TabIndex = 0;
            //
            // nameHeader
            //
            nameHeader.AutoSize = true;
            nameHeader.BackColor = Color.Transparent;
            nameHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            nameHeader.ForeColor = Color.White;
            nameHeader.Margin = new Padding(10, 5, 30, 0);
            nameHeader.Name = "nameHeader";
            nameHeader.Size = new Size(55, 23);
            nameHeader.Text = "Name";
            //
            // categoryHeader
            //
            categoryHeader.AutoSize = true;
            categoryHeader.BackColor = Color.Transparent;
            categoryHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            categoryHeader.ForeColor = Color.White;
            categoryHeader.Margin = new Padding(10, 5, 30, 0);
            categoryHeader.Name = "categoryHeader";
            categoryHeader.Size = new Size(80, 23);
            categoryHeader.Text = "Category";
            //
            // priceHeader
            //
            priceHeader.AutoSize = true;
            priceHeader.BackColor = Color.Transparent;
            priceHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            priceHeader.ForeColor = Color.White;
            priceHeader.Margin = new Padding(10, 5, 30, 0);
            priceHeader.Name = "priceHeader";
            priceHeader.Size = new Size(50, 23);
            priceHeader.Text = "Price";
            //
            // stockHeader
            //
            stockHeader.AutoSize = true;
            stockHeader.BackColor = Color.Transparent;
            stockHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            stockHeader.ForeColor = Color.White;
            stockHeader.Margin = new Padding(10, 5, 30, 0);
            stockHeader.Name = "stockHeader";
            stockHeader.Size = new Size(54, 23);
            stockHeader.Text = "Stock";
            //
            // pnlRight
            //
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(lblFormTitle);
            pnlRight.Controls.Add(lblNameL);
            pnlRight.Controls.Add(txtName);
            pnlRight.Controls.Add(lblDescriptionL);
            pnlRight.Controls.Add(txtDescription);
            pnlRight.Controls.Add(lblCategoryL);
            pnlRight.Controls.Add(cmbCategory);
            pnlRight.Controls.Add(lblPriceL);
            pnlRight.Controls.Add(txtPrice);
            pnlRight.Controls.Add(lblStockL);
            pnlRight.Controls.Add(txtStock);
            pnlRight.Controls.Add(lblImageL);
            pnlRight.Controls.Add(picProductImage);
            pnlRight.Controls.Add(btnChooseImage);
            pnlRight.Controls.Add(btnSave);
            pnlRight.Controls.Add(btnNew);
            pnlRight.Location = new Point(700, 50);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(400, 720);
            pnlRight.TabIndex = 2;
            //
            // lblFormTitle
            //
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblFormTitle.Location = new Point(20, 12);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(160, 28);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Product Details";
            //
            // lblNameL
            //
            lblNameL.AutoSize = true;
            lblNameL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNameL.ForeColor = Color.FromArgb(33, 33, 33);
            lblNameL.Location = new Point(20, 50);
            lblNameL.Name = "lblNameL";
            lblNameL.Size = new Size(70, 20);
            lblNameL.TabIndex = 1;
            lblNameL.Text = "Name *";
            //
            // txtName
            //
            txtName.BackColor = Color.LightGray;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(20, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(350, 30);
            txtName.TabIndex = 2;
            //
            // lblDescriptionL
            //
            lblDescriptionL.AutoSize = true;
            lblDescriptionL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescriptionL.ForeColor = Color.FromArgb(33, 33, 33);
            lblDescriptionL.Location = new Point(20, 110);
            lblDescriptionL.Name = "lblDescriptionL";
            lblDescriptionL.Size = new Size(88, 20);
            lblDescriptionL.TabIndex = 3;
            lblDescriptionL.Text = "Description";
            //
            // txtDescription
            //
            txtDescription.BackColor = Color.LightGray;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(20, 132);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(350, 60);
            txtDescription.TabIndex = 4;
            //
            // lblCategoryL
            //
            lblCategoryL.AutoSize = true;
            lblCategoryL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoryL.ForeColor = Color.FromArgb(33, 33, 33);
            lblCategoryL.Location = new Point(20, 200);
            lblCategoryL.Name = "lblCategoryL";
            lblCategoryL.Size = new Size(80, 20);
            lblCategoryL.TabIndex = 5;
            lblCategoryL.Text = "Category *";
            //
            // cmbCategory
            //
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.Location = new Point(20, 222);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 31);
            cmbCategory.TabIndex = 6;
            //
            // lblPriceL
            //
            lblPriceL.AutoSize = true;
            lblPriceL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPriceL.ForeColor = Color.FromArgb(33, 33, 33);
            lblPriceL.Location = new Point(20, 260);
            lblPriceL.Name = "lblPriceL";
            lblPriceL.Size = new Size(60, 20);
            lblPriceL.TabIndex = 7;
            lblPriceL.Text = "Price *";
            //
            // txtPrice
            //
            txtPrice.BackColor = Color.LightGray;
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Location = new Point(20, 282);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 30);
            txtPrice.TabIndex = 8;
            //
            // lblStockL
            //
            lblStockL.AutoSize = true;
            lblStockL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStockL.ForeColor = Color.FromArgb(33, 33, 33);
            lblStockL.Location = new Point(190, 260);
            lblStockL.Name = "lblStockL";
            lblStockL.Size = new Size(62, 20);
            lblStockL.TabIndex = 9;
            lblStockL.Text = "Stock *";
            //
            // txtStock
            //
            txtStock.BackColor = Color.LightGray;
            txtStock.Font = new Font("Segoe UI", 10F);
            txtStock.Location = new Point(190, 282);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 30);
            txtStock.TabIndex = 10;
            //
            // lblImageL
            //
            lblImageL.AutoSize = true;
            lblImageL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblImageL.ForeColor = Color.FromArgb(33, 33, 33);
            lblImageL.Location = new Point(20, 320);
            lblImageL.Name = "lblImageL";
            lblImageL.Size = new Size(80, 20);
            lblImageL.TabIndex = 11;
            lblImageL.Text = "Image";
            //
            // picProductImage
            //
            picProductImage.BackColor = Color.FromArgb(220, 220, 220);
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(20, 342);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(120, 120);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 12;
            picProductImage.TabStop = false;
            //
            // btnChooseImage
            //
            btnChooseImage.BackColor = Color.FromArgb(46, 125, 50);
            btnChooseImage.ForeColor = Color.White;
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChooseImage.Cursor = Cursors.Hand;
            btnChooseImage.Location = new Point(155, 372);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(150, 40);
            btnChooseImage.TabIndex = 13;
            btnChooseImage.Text = "Choose Image";
            btnChooseImage.UseVisualStyleBackColor = false;
            btnChooseImage.Click += btnChooseImage_Click;
            //
            // btnSave
            //
            btnSave.BackColor = Color.FromArgb(46, 125, 50);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(20, 482);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 44);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnNew
            //
            btnNew.BackColor = Color.LightGray;
            btnNew.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNew.Cursor = Cursors.Hand;
            btnNew.Location = new Point(200, 482);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(160, 44);
            btnNew.TabIndex = 15;
            btnNew.Text = "New Product";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            //
            // AdminProductsForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 245);
            ClientSize = new Size(1100, 770);
            Controls.Add(pnlRight);
            Controls.Add(productsContainer);
            Controls.Add(lblHeader);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = IconHelper.GetAppIcon();
            MaximizeBox = false;
            Name = "AdminProductsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ZooZen - Product Management";
            Load += AdminProductsForm_Load;
            productsContainer.ResumeLayout(false);
            productsHeaders.ResumeLayout(false);
            productsHeaders.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeader;
        private FlowLayoutPanel productsContainer;
        private FlowLayoutPanel productsHeaders;
        private Label nameHeader;
        private Label categoryHeader;
        private Label priceHeader;
        private Label stockHeader;
        private Panel pnlRight;
        private Label lblFormTitle;
        private Label lblNameL;
        private TextBox txtName;
        private Label lblDescriptionL;
        private TextBox txtDescription;
        private Label lblCategoryL;
        private ComboBox cmbCategory;
        private Label lblPriceL;
        private TextBox txtPrice;
        private Label lblStockL;
        private TextBox txtStock;
        private Label lblImageL;
        private PictureBox picProductImage;
        private Button btnChooseImage;
        private Button btnSave;
        private Button btnNew;
    }
}
