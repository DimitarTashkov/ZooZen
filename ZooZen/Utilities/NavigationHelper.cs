using ZooZen.Extensions;
using ZooZen.Models.Enums;
using ZooZen.Services.Interfaces;

namespace ZooZen.Utilities
{
    /// <summary>
    /// Builds a consistent navigation MenuStrip for any form in the application.
    /// </summary>
    public static class NavigationHelper
    {
        /// <summary>
        /// Creates a styled navigation MenuStrip with the 5 required menus.
        /// When a navigation item is clicked from a child form, it closes the form
        /// and sets a result tag so the parent (MainForm) can handle it.
        /// </summary>
        public static MenuStrip CreateNavigationMenu(Form ownerForm, bool showAdminMenu = false)
        {
            var menu = new MenuStrip
            {
                BackColor = Color.FromArgb(27, 68, 30),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Padding = new Padding(7, 1, 0, 7),
                Dock = DockStyle.Top
            };

            var home = CreateItem("Home");
            home.Click += (s, e) => Navigate(ownerForm, "Home");

            // 1. Catalog
            var catalog = CreateItem("Catalog");
            var catAll = CreateDropItem("All Products");
            catAll.Click += (s, e) => Navigate(ownerForm, "catalogAll");
            var catAnimals = CreateDropItem("Animals");
            catAnimals.Click += (s, e) => Navigate(ownerForm, "catalogAnimals");
            var catFood = CreateDropItem("Food");
            catFood.Click += (s, e) => Navigate(ownerForm, "catalogFood");
            var catCosmetics = CreateDropItem("Cosmetics");
            catCosmetics.Click += (s, e) => Navigate(ownerForm, "catalogCosmetics");
            var catAccessories = CreateDropItem("Accessories");
            catAccessories.Click += (s, e) => Navigate(ownerForm, "catalogAccessories");
            catalog.DropDownItems.AddRange([catAll, catAnimals, catFood, catCosmetics, catAccessories]);

            // 2. Promotions
            var promos = CreateItem("Promotions");
            promos.Click += (s, e) => Navigate(ownerForm, "Promotions");

            // 3. Cart
            var cart = CreateItem("Cart");
            cart.Click += (s, e) => Navigate(ownerForm, "Cart");

            // 4. My Profile
            var profile = CreateItem("My Profile");
            var profileData = CreateDropItem("Personal Info");
            profileData.Click += (s, e) => Navigate(ownerForm, "profileData");
            var profileOrders = CreateDropItem("Order History");
            profileOrders.Click += (s, e) => Navigate(ownerForm, "profileOrders");
            var profileLogout = CreateDropItem("Logout");
            profileLogout.ForeColor = Color.FromArgb(255, 150, 150);
            profileLogout.Click += (s, e) => Navigate(ownerForm, "profileLogout");
            profile.DropDownItems.AddRange([profileData, profileOrders, profileLogout]);

            // 5. Management (admin only)
            var management = CreateItem("Management");
            management.Visible = showAdminMenu;
            var manageProducts = CreateDropItem("Products");
            manageProducts.Click += (s, e) => Navigate(ownerForm, "manageProducts");
            var manageUsers = CreateDropItem("Users");
            manageUsers.Click += (s, e) => Navigate(ownerForm, "manageUsers");
            management.DropDownItems.AddRange([manageProducts, manageUsers]);

            menu.Items.AddRange([home, catalog, promos, cart, profile, management]);
            return menu;
        }

        private static ToolStripMenuItem CreateItem(string text) => new()
        {
            Text = text,
            ForeColor = Color.FromArgb(165, 214, 167),
            Padding = new Padding(4, 0, 4, 0)
        };

        private static ToolStripMenuItem CreateDropItem(string text) => new()
        {
            Text = text,
            BackColor = Color.FromArgb(27, 68, 30),
            ForeColor = Color.FromArgb(165, 214, 167)
        };

        /// <summary>
        /// Handles navigation from a child form. Stores the navigation target
        /// in the form's Tag and closes it so the MainForm can pick it up.
        /// </summary>
        private static void Navigate(Form form, string target)
        {
            form.Tag = $"NAV:{target}";
            form.DialogResult = DialogResult.Retry;
            form.Close();
        }
    }
}
