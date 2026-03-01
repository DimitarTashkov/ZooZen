using ZooZen.Models;
using ZooZen.Services.Interfaces;
using ZooZen.Utilities;
using static ZooZen.Utilities.DynamicContentTranslator.EntitiesTranslation;

namespace ZooZen.Forms
{
    /// <summary>
    /// Checkout form for completing orders.
    /// Fields: Name, Phone, Address, Promo Code. Button "Pay & Generate Invoice".
    /// </summary>
    public partial class CheckoutForm : Form
    {
        private readonly IOrderService   _orderService;
        private readonly IInvoiceService _invoiceService;
        private readonly IUserService    _userService;
        private readonly List<(Guid ProductId, int Quantity)> _items;
        private readonly decimal _subtotal;

        public CheckoutForm(
            IOrderService   orderService,
            IInvoiceService invoiceService,
            IUserService    userService,
            List<(Guid ProductId, int Quantity)> items,
            decimal subtotal)
        {
            _orderService   = orderService;
            _invoiceService = invoiceService;
            _userService    = userService;
            _items          = items;
            _subtotal       = subtotal;
            InitializeComponent();

            var nav = NavigationHelper.CreateNavigationMenu(this, AuthorizationHelper.IsAuthorized());
            Controls.Add(nav);
            nav.BringToFront();

            int navHeight = nav.PreferredSize.Height;
            formPanel.Location = new Point(0, navHeight);
            formPanel.Size = new Size(ClientSize.Width, ClientSize.Height - navHeight);
            ClientSize = new Size(ClientSize.Width, ClientSize.Height + navHeight);
            formPanel.BringToFront();
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            // Pre-fill user data
            var user = _userService.GetLoggedInUserAsync();
            if (user != null)
            {
                txtName.Text    = $"{user.FirstName} {user.LastName}".Trim();
                txtPhone.Text   = user.Phone ?? "";
                txtAddress.Text = user.Address ?? "";
            }

            lblSubtotal.Text = $"Subtotal: ${_subtotal:F2}";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtName.Text)    ||
                string.IsNullOrWhiteSpace(txtPhone.Text)   ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show(EmptyInputData, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _userService.GetLoggedInUserAsync();
            if (user == null) return;

            string? promoCode = string.IsNullOrWhiteSpace(txtPromo.Text) ? null : txtPromo.Text.Trim().ToUpper();

            try
            {
                var order = _orderService.CreateOrder(
                    userId:          user.Id,
                    customerName:    txtName.Text.Trim(),
                    customerPhone:   txtPhone.Text.Trim(),
                    customerAddress: txtAddress.Text.Trim(),
                    items:           _items,
                    promoCode:       promoCode);

                // Mark as paid
                _orderService.MarkOrderAsPaid(order.Id);

                // Reload order with details for invoice
                var paidOrder = _orderService.GetOrderById(order.Id);

                // Generate and save the invoice
                GenerateAndSaveInvoice(paidOrder!);

                MessageBox.Show(OrderPlaced, "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "ZooZen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateAndSaveInvoice(Order order)
        {
            string invoiceText = _invoiceService.GenerateInvoiceText(order);

            using var dlg = new SaveFileDialog
            {
                Filter   = "Text file (*.txt)|*.txt",
                FileName = $"Invoice_{order.Id.ToString()[..8].ToUpper()}.txt",
                Title    = "Save Invoice"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, invoiceText, System.Text.Encoding.UTF8);
                MessageBox.Show(
                    $"Invoice saved successfully!\n{dlg.FileName}",
                    "ZooZen - Invoice",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtPromo_TextChanged(object sender, EventArgs e)
        {
            // Show discount preview when entering promo code
            string code = txtPromo.Text.Trim().ToUpper();
            decimal discount = code switch
            {
                "ZOOZEN10" => _subtotal * 0.10m,
                "ZOOZEN20" => _subtotal * 0.20m,
                "PETLOVER" => _subtotal * 0.15m,
                _ => 0m
            };

            if (discount > 0)
            {
                lblDiscount.Text    = $"Discount: -${discount:F2}";
                lblDiscount.Visible = true;
                lblFinalTotal.Text  = $"Final Total: ${_subtotal - discount:F2}";
            }
            else
            {
                lblDiscount.Visible = false;
                lblFinalTotal.Text  = $"Final Total: ${_subtotal:F2}";
            }
        }
    }
}
