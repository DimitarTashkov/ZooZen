using ZooZen.Utilities;

namespace ZooZen.Forms
{
    partial class MainForm
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
            footer = new Button();
            catalogButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menu = new MenuStrip();
            Home = new ToolStripMenuItem();
            Catalog = new ToolStripMenuItem();
            catalogAll = new ToolStripMenuItem();
            catalogAnimals = new ToolStripMenuItem();
            catalogFood = new ToolStripMenuItem();
            catalogCosmetics = new ToolStripMenuItem();
            catalogAccessories = new ToolStripMenuItem();
            Promotions = new ToolStripMenuItem();
            Cart = new ToolStripMenuItem();
            MyProfile = new ToolStripMenuItem();
            profileData = new ToolStripMenuItem();
            profileOrders = new ToolStripMenuItem();
            profileLogout = new ToolStripMenuItem();
            Management = new ToolStripMenuItem();
            manageProducts = new ToolStripMenuItem();
            manageUsers = new ToolStripMenuItem();
            welcomeMessage = new Label();
            aboutUs = new Label();
            contactUs = new Label();
            roundPictureBox1 = new ZooZen.Utilities.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            SuspendLayout();
            //
            // footer
            //
            footer.BackColor = Color.FromArgb(27, 68, 30);
            footer.ForeColor = Color.White;
            footer.FlatStyle = FlatStyle.Flat;
            footer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            footer.Cursor = Cursors.Default;
            footer.Location = new Point(0, 545);
            footer.Margin = new Padding(3, 4, 3, 4);
            footer.Name = "footer";
            footer.Size = new Size(931, 52);
            footer.TabIndex = 18;
            footer.Text = "\u24B8 ZooZen 2025";
            footer.UseVisualStyleBackColor = false;
            //
            // catalogButton
            //
            catalogButton.BackColor = Color.FromArgb(46, 125, 50);
            catalogButton.ForeColor = Color.White;
            catalogButton.FlatStyle = FlatStyle.Flat;
            catalogButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            catalogButton.Cursor = Cursors.Hand;
            catalogButton.Location = new Point(350, 437);
            catalogButton.Margin = new Padding(3, 4, 3, 4);
            catalogButton.Name = "catalogButton";
            catalogButton.Size = new Size(232, 67);
            catalogButton.TabIndex = 16;
            catalogButton.Text = "Browse Products";
            catalogButton.UseVisualStyleBackColor = false;
            catalogButton.Click += catalogButton_Click;
            //
            // pictureBox1
            //
            pictureBox1.Location = new Point(0, 115);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(457, 309);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            //
            // pictureBox2
            //
            pictureBox2.Location = new Point(458, 115);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(457, 309);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            //
            // menu
            //
            menu.BackColor = Color.FromArgb(27, 68, 30);
            menu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { Home, Catalog, Promotions, Cart, MyProfile, Management });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(7, 1, 0, 7);
            menu.Size = new Size(914, 42);
            menu.TabIndex = 11;
            menu.Text = "Menu";
            //
            // Home
            //
            Home.ForeColor = Color.FromArgb(165, 214, 167);
            Home.Name = "Home";
            Home.Size = new Size(91, 34);
            Home.Text = "Home";
            Home.Click += menu_ItemClicked;
            //
            // Catalog
            //
            Catalog.DropDownItems.AddRange(new ToolStripItem[] { catalogAll, catalogAnimals, catalogFood, catalogCosmetics, catalogAccessories });
            Catalog.ForeColor = Color.FromArgb(165, 214, 167);
            Catalog.Name = "Catalog";
            Catalog.Padding = new Padding(4, 0, 4, 5);
            Catalog.Size = new Size(105, 34);
            Catalog.Text = "Catalog";
            //
            // catalogAll
            //
            catalogAll.BackColor = Color.FromArgb(27, 68, 30);
            catalogAll.ForeColor = Color.FromArgb(165, 214, 167);
            catalogAll.Name = "catalogAll";
            catalogAll.Size = new Size(198, 30);
            catalogAll.Text = "All Products";
            catalogAll.Click += menu_ItemClicked;
            //
            // catalogAnimals
            //
            catalogAnimals.BackColor = Color.FromArgb(27, 68, 30);
            catalogAnimals.ForeColor = Color.FromArgb(165, 214, 167);
            catalogAnimals.Name = "catalogAnimals";
            catalogAnimals.Size = new Size(198, 30);
            catalogAnimals.Text = "Animals";
            catalogAnimals.Click += menu_ItemClicked;
            //
            // catalogFood
            //
            catalogFood.BackColor = Color.FromArgb(27, 68, 30);
            catalogFood.ForeColor = Color.FromArgb(165, 214, 167);
            catalogFood.Name = "catalogFood";
            catalogFood.Size = new Size(198, 30);
            catalogFood.Text = "Food";
            catalogFood.Click += menu_ItemClicked;
            //
            // catalogCosmetics
            //
            catalogCosmetics.BackColor = Color.FromArgb(27, 68, 30);
            catalogCosmetics.ForeColor = Color.FromArgb(165, 214, 167);
            catalogCosmetics.Name = "catalogCosmetics";
            catalogCosmetics.Size = new Size(198, 30);
            catalogCosmetics.Text = "Cosmetics";
            catalogCosmetics.Click += menu_ItemClicked;
            //
            // catalogAccessories
            //
            catalogAccessories.BackColor = Color.FromArgb(27, 68, 30);
            catalogAccessories.ForeColor = Color.FromArgb(165, 214, 167);
            catalogAccessories.Name = "catalogAccessories";
            catalogAccessories.Size = new Size(198, 30);
            catalogAccessories.Text = "Accessories";
            catalogAccessories.Click += menu_ItemClicked;
            //
            // Promotions
            //
            Promotions.ForeColor = Color.FromArgb(165, 214, 167);
            Promotions.Name = "Promotions";
            Promotions.Padding = new Padding(4, 0, 4, 5);
            Promotions.Size = new Size(140, 34);
            Promotions.Text = "Promotions";
            Promotions.Click += menu_ItemClicked;
            //
            // Cart
            //
            Cart.ForeColor = Color.FromArgb(165, 214, 167);
            Cart.Name = "Cart";
            Cart.Padding = new Padding(4, 0, 4, 5);
            Cart.Size = new Size(120, 34);
            Cart.Text = "  Cart (0)";
            Cart.Click += menu_ItemClicked;
            //
            // MyProfile
            //
            MyProfile.DropDownItems.AddRange(new ToolStripItem[] { profileData, profileOrders, profileLogout });
            MyProfile.ForeColor = Color.FromArgb(165, 214, 167);
            MyProfile.Name = "MyProfile";
            MyProfile.Padding = new Padding(4, 0, 4, 5);
            MyProfile.Size = new Size(130, 34);
            MyProfile.Text = "My Profile";
            //
            // profileData
            //
            profileData.BackColor = Color.FromArgb(27, 68, 30);
            profileData.ForeColor = Color.FromArgb(165, 214, 167);
            profileData.Name = "profileData";
            profileData.Size = new Size(198, 30);
            profileData.Text = "Personal Info";
            profileData.Click += menu_ItemClicked;
            //
            // profileOrders
            //
            profileOrders.BackColor = Color.FromArgb(27, 68, 30);
            profileOrders.ForeColor = Color.FromArgb(165, 214, 167);
            profileOrders.Name = "profileOrders";
            profileOrders.Size = new Size(198, 30);
            profileOrders.Text = "Order History";
            profileOrders.Click += menu_ItemClicked;
            //
            // profileLogout
            //
            profileLogout.BackColor = Color.FromArgb(27, 68, 30);
            profileLogout.ForeColor = Color.FromArgb(255, 150, 150);
            profileLogout.Name = "profileLogout";
            profileLogout.Size = new Size(198, 30);
            profileLogout.Text = "Logout";
            profileLogout.Click += menu_ItemClicked;
            //
            // Management
            //
            Management.DropDownItems.AddRange(new ToolStripItem[] { manageProducts, manageUsers });
            Management.ForeColor = Color.FromArgb(165, 214, 167);
            Management.Name = "Management";
            Management.Size = new Size(169, 34);
            Management.Text = "Management";
            Management.Visible = false;
            //
            // manageProducts
            //
            manageProducts.BackColor = Color.FromArgb(27, 68, 30);
            manageProducts.ForeColor = Color.FromArgb(165, 214, 167);
            manageProducts.Name = "manageProducts";
            manageProducts.Size = new Size(198, 30);
            manageProducts.Text = "Products";
            manageProducts.Click += menu_ItemClicked;
            //
            // manageUsers
            //
            manageUsers.BackColor = Color.FromArgb(27, 68, 30);
            manageUsers.ForeColor = Color.FromArgb(165, 214, 167);
            manageUsers.Name = "manageUsers";
            manageUsers.Size = new Size(198, 30);
            manageUsers.Text = "Users";
            manageUsers.Click += menu_ItemClicked;
            //
            // welcomeMessage
            //
            welcomeMessage.BackColor = Color.Transparent;
            welcomeMessage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            welcomeMessage.ForeColor = Color.White;
            welcomeMessage.TextAlign = ContentAlignment.MiddleCenter;
            welcomeMessage.Location = new Point(28, 70);
            welcomeMessage.Name = "welcomeMessage";
            welcomeMessage.Size = new Size(856, 41);
            welcomeMessage.TabIndex = 23;
            welcomeMessage.Text = "Welcome to ZooZen \u2014 everything your pet needs.";
            //
            // aboutUs
            //
            aboutUs.AutoSize = true;
            aboutUs.BackColor = Color.Transparent;
            aboutUs.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            aboutUs.ForeColor = Color.White;
            aboutUs.Cursor = Cursors.Hand;
            aboutUs.TextAlign = ContentAlignment.MiddleCenter;
            aboutUs.Location = new Point(160, 556);
            aboutUs.Name = "aboutUs";
            aboutUs.Size = new Size(93, 25);
            aboutUs.TabIndex = 20;
            aboutUs.Text = "About us";
            aboutUs.Click += aboutUs_Click;
            //
            // contactUs
            //
            contactUs.AutoSize = true;
            contactUs.BackColor = Color.Transparent;
            contactUs.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            contactUs.ForeColor = Color.White;
            contactUs.Cursor = Cursors.Hand;
            contactUs.TextAlign = ContentAlignment.MiddleCenter;
            contactUs.Location = new Point(704, 556);
            contactUs.Name = "contactUs";
            contactUs.Size = new Size(106, 25);
            contactUs.TabIndex = 21;
            contactUs.Text = "Contact us";
            contactUs.Click += contactUs_Click;
            //
            // roundPictureBox1
            //
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.Location = new Point(853, 0);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(57, 47);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 24;
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(roundPictureBox1);
            Controls.Add(welcomeMessage);
            Controls.Add(contactUs);
            Controls.Add(aboutUs);
            Controls.Add(footer);
            Controls.Add(catalogButton);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(menu);
            DoubleBuffered = true;
            Icon = IconHelper.GetAppIcon();
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZooZen";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button footer;
        private Button catalogButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menu;
        private ToolStripMenuItem Home;
        private ToolStripMenuItem Catalog;
        private ToolStripMenuItem catalogAll;
        private ToolStripMenuItem catalogAnimals;
        private ToolStripMenuItem catalogFood;
        private ToolStripMenuItem catalogCosmetics;
        private ToolStripMenuItem catalogAccessories;
        private ToolStripMenuItem Promotions;
        private ToolStripMenuItem Cart;
        private ToolStripMenuItem MyProfile;
        private ToolStripMenuItem profileData;
        private ToolStripMenuItem profileOrders;
        private ToolStripMenuItem profileLogout;
        private ToolStripMenuItem Management;
        private ToolStripMenuItem manageProducts;
        private ToolStripMenuItem manageUsers;
        private Label welcomeMessage;
        private Label aboutUs;
        private Label contactUs;
        private ZooZen.Utilities.RoundPictureBox roundPictureBox1;
    }
}
