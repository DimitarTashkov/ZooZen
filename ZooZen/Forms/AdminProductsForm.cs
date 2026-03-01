using ZooZen.Common.Constants;
using ZooZen.Models;
using ZooZen.Models.Enums;
using ZooZen.Services.Interfaces;
using ZooZen.Utilities;
using static ZooZen.Utilities.DynamicContentTranslator.EntitiesTranslation;

namespace ZooZen.Forms
{
    public partial class AdminProductsForm : Form
    {
        private readonly IProductService _productService;
        private Product? _editing = null;
        private string? _selectedImagePath = null;

        public AdminProductsForm(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();

            var nav = NavigationHelper.CreateNavigationMenu(this, AuthorizationHelper.IsAuthorized());
            Controls.Add(nav);
            nav.BringToFront();
            lblHeader.BringToFront();

            // Shift content down to account for nav height
            int navHeight = nav.PreferredSize.Height;
            lblHeader.Location = new Point(lblHeader.Location.X, navHeight);
            productsContainer.Location = new Point(productsContainer.Location.X, navHeight + lblHeader.Height);
            pnlRight.Location = new Point(pnlRight.Location.X, navHeight + lblHeader.Height);
            ClientSize = new Size(ClientSize.Width, ClientSize.Height + navHeight);
        }

        private void AdminProductsForm_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = Enum.GetValues<ProductCategory>();
            RefreshProductsList();
        }

        private void RefreshProductsList()
        {
            while (productsContainer.Controls.Count > 1)
                productsContainer.Controls.RemoveAt(1);

            var products = _productService.GetAllProducts();
            int index = 0;

            foreach (var product in products)
            {
                var row = new FlowLayoutPanel
                {
                    Name = $"productRow{index}",
                    Size = new Size(680, 130),
                    Margin = new Padding(0, 5, 0, 5),
                    BackColor = Color.White
                };

                var name = new Label
                {
                    Name = $"name{index}",
                    Text = product.Name,
                    Font = new Font("Segoe UI", 10F),
                    AutoSize = true,
                    Margin = new Padding(10, 5, 20, 0)
                };

                var category = new Label
                {
                    Name = $"category{index}",
                    Text = GetCategoryName(product.Category),
                    Font = new Font("Segoe UI", 10F),
                    AutoSize = true,
                    Margin = new Padding(10, 5, 20, 0)
                };

                var price = new Label
                {
                    Name = $"price{index}",
                    Text = $"${product.Price:F2}",
                    Font = new Font("Segoe UI", 10F),
                    AutoSize = true,
                    Margin = new Padding(10, 5, 20, 0)
                };

                var stock = new Label
                {
                    Name = $"stock{index}",
                    Text = product.StockQuantity.ToString(),
                    Font = new Font("Segoe UI", 10F),
                    AutoSize = true,
                    Margin = new Padding(10, 5, 20, 0)
                };

                var capturedProduct = product;

                var edit = new Button
                {
                    Name = $"edit{index}",
                    Text = Edit,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    BackColor = Color.FromArgb(46, 125, 50),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    AutoSize = true,
                    Margin = new Padding(200, 0, 0, 0),
                    Cursor = Cursors.Hand
                };
                edit.FlatAppearance.BorderSize = 0;

                edit.Click += (s, ev) =>
                {
                    LoadProductToForm(capturedProduct);
                };

                var delete = new Button
                {
                    Name = $"delete{index}",
                    Text = Delete,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    AutoSize = true,
                    Margin = new Padding(10, 0, 0, 0),
                    Cursor = Cursors.Hand
                };
                delete.FlatAppearance.BorderSize = 0;

                delete.Click += (s, ev) =>
                {
                    if (MessageBox.Show($"Delete '{capturedProduct.Name}'?", Confirmation, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _productService.DeleteProduct(capturedProduct.Id);
                        ClearForm();
                        RefreshProductsList();
                    }
                };

                row.Controls.Add(name);
                row.Controls.Add(category);
                row.Controls.Add(price);
                row.Controls.Add(stock);
                row.Controls.Add(edit);
                row.Controls.Add(delete);

                productsContainer.Controls.Add(row);
                index++;
            }
        }

        private void LoadProductToForm(Product p)
        {
            _editing = p;
            txtName.Text = p.Name;
            txtDescription.Text = p.Description ?? "";
            txtPrice.Text = p.Price.ToString("F2");
            txtStock.Text = p.StockQuantity.ToString();
            cmbCategory.SelectedItem = p.Category;
            txtImageUrl.Text = p.ImageUrl ?? "";
            _selectedImagePath = p.ImageUrl;
            btnSave.Text = "Save Changes";
            lblFormTitle.Text = "Edit Product";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a product name!", "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal price) || price < 0)
            {
                MessageBox.Show("Invalid price!", "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Invalid stock quantity!", "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string? finalImage = string.IsNullOrWhiteSpace(txtImageUrl.Text) ? null : txtImageUrl.Text.Trim();

            var product = _editing ?? new Product();
            product.Name = txtName.Text.Trim();
            product.Description = txtDescription.Text.Trim();
            product.Price = price;
            product.StockQuantity = stock;
            product.Category = (ProductCategory)cmbCategory.SelectedItem!;
            product.ImageUrl = finalImage;

            if (_editing == null)
                _productService.AddProduct(product);
            else
                _productService.UpdateProduct(product);

            MessageBox.Show(EditSucceeded, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            RefreshProductsList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            _editing = null;
            _selectedImagePath = null;
            txtName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            txtImageUrl.Text = "";
            cmbCategory.SelectedIndex = 0;
            btnSave.Text = "Save Product";
            lblFormTitle.Text = "New Product";
        }

        private static string GetCategoryName(ProductCategory c) => c switch
        {
            ProductCategory.Animal => "Animals",
            ProductCategory.Food => "Food",
            ProductCategory.Cosmetic => "Cosmetics",
            ProductCategory.Accessory => "Accessories",
            ProductCategory.ServicePromo => "Promotion",
            _ => c.ToString()
        };
    }
}
