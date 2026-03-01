using System.Drawing;
using System.Runtime.InteropServices;

namespace ZooZen.Utilities
{
    /// <summary>
    /// Helper for generating the application icon from the logo resource.
    /// </summary>
    public static class IconHelper
    {
        private static Icon? _cachedIcon;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        /// <summary>
        /// Returns the ZooZen application icon derived from the logo resource.
        /// The icon is created once and cached for subsequent calls.
        /// </summary>
        public static Icon GetAppIcon()
        {
            if (_cachedIcon != null)
                return _cachedIcon;

            using var bmp = new Bitmap(Properties.Resources.logo, 32, 32);
            IntPtr hIcon = bmp.GetHicon();
            _cachedIcon = Icon.FromHandle(hIcon).Clone() as Icon ?? SystemIcons.Application;
            DestroyIcon(hIcon);

            return _cachedIcon;
        }
    }
}
