using ZooZen.Extensions;
using ZooZen.Models;
using ZooZen.Models.Enums;
using ZooZen.Services.Interfaces;
using ZooZen.Utilities;
using static ZooZen.Utilities.DynamicContentTranslator.EntitiesTranslation;

namespace ZooZen.Forms
{
    public partial class MainForm : Form
    {
        private readonly IUserService    _userService;
        private readonly IProductService _productService;
        private readonly IOrderService   _orderService;
        private readonly IInvoiceService _invoiceService;
        private User? _activeUser;

        private readonly Dictionary<Guid, (Product Product, int Quantity)> _cart = new();

        public MainForm(IUserService userService)
        {
            _userService    = userService;
            _productService = ServiceLocator.GetService<IProductService>();
            _orderService   = ServiceLocator.GetService<IOrderService>();
            _invoiceService = ServiceLocator.GetService<IInvoiceService>();
            _activeUser     = userService.GetLoggedInUserAsync();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _activeUser = _userService.GetLoggedInUserAsync();
            bool isAdmin = AuthorizationHelper.IsAuthorized();
            Management.Visible = isAdmin;
        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            if (_activeUser == null) return;
            OpenChildForm(() => new ProfileForm(_userService, _activeUser.Id));
            _activeUser = _userService.GetLoggedInUserAsync();
        }

        private void catalogButton_Click(object sender, EventArgs e)
        {
            OpenCatalog(null);
        }

        private void aboutUs_Click(object sender, EventArgs e)
        {
            OpenChildForm(() => new AboutUsForm());
        }

        private void contactUs_Click(object sender, EventArgs e)
        {
            OpenChildForm(() => new ContactUsForm());
        }

        private void menu_ItemClicked(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null) return;
            HandleNavigation(item.Name);
        }

        /// <summary>
        /// Central navigation handler used both by MainForm menu clicks
        /// and by navigation returns from child forms.
        /// </summary>
        private void HandleNavigation(string target)
        {
            switch (target)
            {
                case "Home":
                    break;
                case "catalogAll":
                    OpenCatalog(null);
                    break;
                case "catalogAnimals":
                    OpenCatalog(ProductCategory.Animal);
                    break;
                case "catalogFood":
                    OpenCatalog(ProductCategory.Food);
                    break;
                case "catalogCosmetics":
                    OpenCatalog(ProductCategory.Cosmetic);
                    break;
                case "catalogAccessories":
                    OpenCatalog(ProductCategory.Accessory);
                    break;
                case "Promotions":
                    OpenCatalog(ProductCategory.ServicePromo);
                    break;
                case "Cart":
                    ShowCartDialog();
                    break;
                case "profileData":
                    if (_activeUser != null)
                    {
                        OpenChildForm(() => new ProfileForm(_userService, _activeUser.Id));
                        _activeUser = _userService.GetLoggedInUserAsync();
                    }
                    break;
                case "profileOrders":
                    OpenChildForm(() => new OrderHistoryForm(_orderService, _invoiceService, _userService));
                    break;
                case "profileLogout":
                    _userService.LogoutUser();
                    _cart.Clear();
                    Program.SwitchMainForm(new Login(_userService));
                    break;
                case "manageProducts":
                    OpenChildForm(() => new AdminProductsForm(_productService));
                    break;
                case "manageUsers":
                    OpenChildForm(() => new AdminUsersForm(_userService));
                    break;
            }
        }

        /// <summary>
        /// Opens a child form as a dialog, then checks if the child requested
        /// navigation to another form. Loops until no more navigation is requested.
        /// </summary>
        private void OpenChildForm(Func<Form> formFactory)
        {
            string? nextNav = null;
            using (var form = formFactory())
            {
                var result = form.ShowDialog(this);
                if (result == DialogResult.Retry && form.Tag is string tag && tag.StartsWith("NAV:"))
                    nextNav = tag[4..];
            }
            if (nextNav != null)
                HandleNavigation(nextNav);
        }

        private void OpenCatalog(ProductCategory? category)
        {
            string? nextNav = null;
            using (var cf = new CatalogForm(_productService, category))
            {
                cf.ProductAddedToCart += AddToCart;
                var result = cf.ShowDialog(this);
                if (result == DialogResult.Retry && cf.Tag is string tag && tag.StartsWith("NAV:"))
                    nextNav = tag[4..];
            }
            if (nextNav != null)
                HandleNavigation(nextNav);
        }

        private void AddToCart(Product product)
        {
            if (_cart.ContainsKey(product.Id))
            {
                if (_cart[product.Id].Quantity < product.StockQuantity)
                    _cart[product.Id] = (product, _cart[product.Id].Quantity + 1);
            }
            else
            {
                _cart[product.Id] = (product, 1);
            }
            UpdateCartLabel();
        }

        private void UpdateCartLabel()
        {
            int total = _cart.Values.Sum(x => x.Quantity);
            Cart.Text = $"  Cart ({total})";
        }

        private void ShowCartDialog()
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show(CartEmpty, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal total = _cart.Values.Sum(x => x.Product.Price * x.Quantity);
            var items = _cart.Values.Select(x => (x.Product.Id, x.Quantity)).ToList();

            string? nextNav = null;
            using (var checkout = new CheckoutForm(_orderService, _invoiceService, _userService, items, total))
            {
                var result = checkout.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _cart.Clear();
                    UpdateCartLabel();
                }
                else if (result == DialogResult.Retry && checkout.Tag is string tag && tag.StartsWith("NAV:"))
                {
                    nextNav = tag[4..];
                }
            }
            if (nextNav != null)
                HandleNavigation(nextNav);
        }
    }
}
