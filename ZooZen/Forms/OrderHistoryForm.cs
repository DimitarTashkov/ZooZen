using ZooZen.Services.Interfaces;
using ZooZen.Utilities;

namespace ZooZen.Forms
{
    public partial class OrderHistoryForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IInvoiceService _invoiceService;
        private readonly IUserService _userService;

        public OrderHistoryForm(IOrderService orderService, IInvoiceService invoiceService, IUserService userService)
        {
            _orderService = orderService;
            _invoiceService = invoiceService;
            _userService = userService;
            InitializeComponent();

            var nav = NavigationHelper.CreateNavigationMenu(this, AuthorizationHelper.IsAuthorized());
            Controls.Add(nav);
            nav.BringToFront();
            lblHeader.BringToFront();

            // Shift content down to account for nav height
            int navHeight = nav.PreferredSize.Height;
            lblHeader.Location = new Point(lblHeader.Location.X, navHeight);
            ordersContainer.Location = new Point(ordersContainer.Location.X, navHeight + lblHeader.Height);
            ClientSize = new Size(ClientSize.Width, ClientSize.Height + navHeight);
        }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            ordersContainer.Controls.Clear();
            ordersContainer.Controls.Add(ordersHeaders);

            var user = _userService.GetLoggedInUserAsync();
            if (user == null) return;

            bool isAdmin = AuthorizationHelper.IsAuthorized();
            var orders = isAdmin
                ? _orderService.GetAllOrders()
                : _orderService.GetOrdersByUserId(user.Id);

            foreach (var order in orders.OrderByDescending(o => o.OrderDate))
            {
                var row = new FlowLayoutPanel
                {
                    Size = new Size(740, 40),
                    BackColor = order.IsPaid ? Color.FromArgb(232, 245, 233) : Color.FromArgb(255, 243, 224),
                    Margin = new Padding(0, 1, 0, 0)
                };

                row.Controls.Add(new Label
                {
                    Text = order.OrderDate.ToString("dd.MM.yyyy"),
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = Color.FromArgb(33, 33, 33),
                    AutoSize = false,
                    Size = new Size(110, 30),
                    Margin = new Padding(10, 8, 10, 0),
                    TextAlign = ContentAlignment.MiddleLeft
                });

                row.Controls.Add(new Label
                {
                    Text = order.CustomerName,
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = Color.FromArgb(33, 33, 33),
                    AutoSize = false,
                    Size = new Size(140, 30),
                    Margin = new Padding(10, 8, 10, 0),
                    TextAlign = ContentAlignment.MiddleLeft
                });

                row.Controls.Add(new Label
                {
                    Text = $"{order.TotalAmount:F2} BGN",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(27, 68, 30),
                    AutoSize = false,
                    Size = new Size(100, 30),
                    Margin = new Padding(10, 8, 10, 0),
                    TextAlign = ContentAlignment.MiddleLeft
                });

                row.Controls.Add(new Label
                {
                    Text = order.IsPaid ? "Paid" : "Pending",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = order.IsPaid ? Color.FromArgb(46, 125, 50) : Color.OrangeRed,
                    AutoSize = false,
                    Size = new Size(80, 30),
                    Margin = new Padding(10, 8, 10, 0),
                    TextAlign = ContentAlignment.MiddleLeft
                });

                var btnInvoice = new Button
                {
                    Text = "Invoice",
                    BackColor = Color.FromArgb(46, 125, 50),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                    Size = new Size(80, 30),
                    Margin = new Padding(10, 5, 5, 0),
                    Cursor = Cursors.Hand,
                    Tag = order.Id
                };
                btnInvoice.Click += BtnInvoice_Click;
                row.Controls.Add(btnInvoice);

                ordersContainer.Controls.Add(row);
            }

            if (orders.Count == 0)
            {
                ordersContainer.Controls.Add(new Label
                {
                    Text = "No orders found.",
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20, 20, 0, 0)
                });
            }
        }

        private void BtnInvoice_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Guid orderId)
            {
                var order = _orderService.GetOrderById(orderId);
                if (order == null) return;

                var invoiceText = _invoiceService.GenerateInvoiceText(order);

                using var sfd = new SaveFileDialog();
                sfd.Filter = "Text files (*.txt)|*.txt";
                sfd.FileName = $"ZooZen_Invoice_{order.OrderDate:yyyyMMdd}_{orderId.ToString()[..8]}.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, invoiceText);
                    MessageBox.Show("Invoice saved successfully!", "ZooZen",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
