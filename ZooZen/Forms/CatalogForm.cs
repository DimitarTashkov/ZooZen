using ZooZen.Models;
using ZooZen.Models.Enums;
using ZooZen.Services.Interfaces;
using ZooZen.Utilities;

namespace ZooZen.Forms
{
    /// <summary>
    /// Standalone catalog form showing products by category
    /// with images, price, and "Add to Cart" button.
    /// Can be opened as a dialog from another form.
    /// </summary>
    public partial class CatalogForm : Form
    {
        private readonly IProductService _productService;
        private readonly ProductCategory? _category;

        // Event to notify the parent form about an added product
        public event Action<Product>? ProductAddedToCart;

        public CatalogForm(IProductService productService, ProductCategory? category = null)
        {
            _productService = productService;
            _category       = category;
            InitializeComponent();

            var nav = NavigationHelper.CreateNavigationMenu(this, AuthorizationHelper.IsAuthorized());
            Controls.Add(nav);
            // Ensure nav docks at the very top (WinForms docks last-added first)
            nav.BringToFront();
            pnlFilter.BringToFront();
            flpProducts.BringToFront();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            // Populate categories in ComboBox
            cmbCategory.Items.Add("All");
            foreach (ProductCategory c in Enum.GetValues<ProductCategory>())
            {
                if (c != ProductCategory.ServicePromo)
                    cmbCategory.Items.Add(GetCategoryLabel(c));
            }
            cmbCategory.SelectedIndex = _category.HasValue && _category.Value != ProductCategory.ServicePromo
                ? (int)_category.Value + 1   // +1 because "All" is at index 0
                : 0;

            LoadProducts();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) => LoadProducts();

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadProducts();

        private void LoadProducts()
        {
            var allProducts = _productService.GetAllProducts()
                .Where(p => p.StockQuantity > 0)
                .ToList();

            // If opened with a specific category (e.g. ServicePromo), show only that
            if (_category.HasValue && cmbCategory.SelectedIndex == 0)
            {
                allProducts = allProducts.Where(p => p.Category == _category.Value).ToList();
            }
            else if (!_category.HasValue || cmbCategory.SelectedIndex > 0)
            {
                // Hide ServicePromo from general catalog browsing
                allProducts = allProducts.Where(p => p.Category != ProductCategory.ServicePromo).ToList();

                // Filter by selected category
                if (cmbCategory.SelectedIndex > 0)
                {
                    var selectedCategory = (ProductCategory)(cmbCategory.SelectedIndex - 1);
                    allProducts = allProducts.Where(p => p.Category == selectedCategory).ToList();
                }
            }

            // Search by text
            string search = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(search))
                allProducts = allProducts
                    .Where(p => p.Name.Contains(search, StringComparison.OrdinalIgnoreCase)
                             || (p.Description != null && p.Description.Contains(search, StringComparison.OrdinalIgnoreCase)))
                    .ToList();

            BuildGrid(allProducts);
        }

        private void BuildGrid(List<Product> products)
        {
            flpProducts.Controls.Clear();

            if (products.Count == 0)
            {
                flpProducts.Controls.Add(new Label
                {
                    Text = "No products found.",
                    Font = new Font("Segoe UI", 12),
                    ForeColor = LayoutHelper.TextMuted,
                    AutoSize = true,
                    Margin = new Padding(20)
                });
                return;
            }

            foreach (var p in products)
            {
                var card = new Panel
                {
                    Size      = new Size(210, 300),
                    BackColor = Color.White,
                    Margin    = new Padding(8),
                    Cursor    = Cursors.Default
                };

                // Border effect
                card.Paint += (s, e) =>
                {
                    using var pen = new Pen(Color.FromArgb(220, 220, 220), 1);
                    e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
                };

                // Product image
                var pb = new PictureBox
                {
                    Size      = new Size(194, 124),
                    Location  = new Point(8, 8),
                    SizeMode  = PictureBoxSizeMode.Zoom,
                    BackColor = Color.FromArgb(238, 245, 238)
                };
                if (!string.IsNullOrEmpty(p.ImageUrl) && File.Exists(p.ImageUrl))
                {
                    try { pb.Image = Image.FromFile(p.ImageUrl); } catch { }
                }
                card.Controls.Add(pb);

                // Category badge
                var lblCat = new Label
                {
                    Text      = GetCategoryLabel(p.Category),
                    Font      = new Font("Segoe UI", 7, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = LayoutHelper.LightGreen,
                    AutoSize  = true,
                    Location  = new Point(8, 138),
                    Padding   = new Padding(4, 2, 4, 2)
                };
                card.Controls.Add(lblCat);

                // Name
                var lblName = new Label
                {
                    Text      = p.Name,
                    Font      = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = LayoutHelper.TextDark,
                    AutoSize  = false,
                    Size      = new Size(194, 40),
                    Location  = new Point(8, 160)
                };
                card.Controls.Add(lblName);

                // Price
                var lblPrice = new Label
                {
                    Text      = $"${p.Price:F2}",
                    Font      = new Font("Segoe UI", 12, FontStyle.Bold),
                    ForeColor = LayoutHelper.PrimaryGreen,
                    AutoSize  = true,
                    Location  = new Point(8, 204)
                };
                card.Controls.Add(lblPrice);

                // Stock
                var lblStock = new Label
                {
                    Text      = $"In Stock: {p.StockQuantity}",
                    Font      = new Font("Segoe UI", 8),
                    ForeColor = LayoutHelper.TextMuted,
                    AutoSize  = true,
                    Location  = new Point(8, 230)
                };
                card.Controls.Add(lblStock);

                // "Add to Cart" button
                var btnAdd = new Button
                {
                    Text     = "+ Add to Cart",
                    Size     = new Size(194, 34),
                    Location = new Point(8, 258),
                    Tag      = p
                };
                LayoutHelper.StylePrimaryButton(btnAdd);
                btnAdd.Click += (s, ev) =>
                {
                    ProductAddedToCart?.Invoke(p);
                    // Visual feedback
                    btnAdd.Text = "Added!";
                    btnAdd.BackColor = Color.FromArgb(56, 142, 60);
                    var t = new System.Windows.Forms.Timer { Interval = 900 };
                    t.Tick += (_, __) => { btnAdd.Text = "+ Add to Cart"; btnAdd.BackColor = LayoutHelper.PrimaryGreen; t.Stop(); t.Dispose(); };
                    t.Start();
                };
                card.Controls.Add(btnAdd);

                flpProducts.Controls.Add(card);
            }
        }

        private static string GetCategoryLabel(ProductCategory c) => c switch
        {
            ProductCategory.Animal       => "Animals",
            ProductCategory.Food         => "Food",
            ProductCategory.Cosmetic     => "Cosmetics",
            ProductCategory.Accessory    => "Accessories",
            ProductCategory.ServicePromo => "Promotion",
            _                            => c.ToString()
        };
    }
}
