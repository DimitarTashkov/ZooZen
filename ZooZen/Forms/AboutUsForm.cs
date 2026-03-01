using ZooZen.Utilities;

namespace ZooZen.Forms
{
    public partial class AboutUsForm : Form
    {
        public AboutUsForm()
        {
            InitializeComponent();

            var nav = NavigationHelper.CreateNavigationMenu(this, AuthorizationHelper.IsAuthorized());
            Controls.Add(nav);
            nav.BringToFront();
            formPanel.BringToFront();

            int navHeight = nav.PreferredSize.Height;
            formPanel.Location = new Point(0, navHeight);
            formPanel.Size = new Size(ClientSize.Width, ClientSize.Height - navHeight);
            ClientSize = new Size(ClientSize.Width, ClientSize.Height + navHeight);
        }
    }
}
