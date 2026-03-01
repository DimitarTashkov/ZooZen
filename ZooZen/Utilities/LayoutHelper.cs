using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZooZen.Utilities
{
    /// <summary>
    /// Helper class for styling ZooZen forms.
    /// Color scheme: green and earth tones, suitable for a pet shop.
    /// </summary>
    public class LayoutHelper
    {
        // -- ZooZen Color Palette --
        public static readonly Color PrimaryGreen    = Color.FromArgb(46, 125, 50);   // Dark green
        public static readonly Color LightGreen      = Color.FromArgb(102, 187, 106); // Light green
        public static readonly Color AccentGreen     = Color.FromArgb(27, 94, 32);    // Accent
        public static readonly Color EarthBrown      = Color.FromArgb(93, 64, 55);    // Earth brown
        public static readonly Color WarmBeige       = Color.FromArgb(245, 245, 220); // Beige
        public static readonly Color DarkSurface     = Color.FromArgb(30, 30, 30);    // Dark surface
        public static readonly Color CardBackground  = Color.FromArgb(255, 255, 255); // Card white
        public static readonly Color TextDark        = Color.FromArgb(33, 33, 33);    // Primary text
        public static readonly Color TextMuted       = Color.FromArgb(117, 117, 117); // Secondary text

        /// <summary>Paints a green gradient background for a panel</summary>
        public static void set_FormBackground(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Panel panel = sender as Panel;
            if (panel == null) return;

            Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);
            using Brush b = new LinearGradientBrush(
                rect,
                Color.FromArgb(27, 94, 32),   // тъмно зелено
                Color.FromArgb(85, 139, 47),  // маслиненo зелено
                LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(b, rect);
        }

        /// <summary>Paints an image background for a panel - falls back to green gradient if resource is missing</summary>
        public static void set_ImageBackground(object sender, PaintEventArgs e)
        {
            Panel? panel = sender as Panel;
            if (panel == null) return;

            System.Drawing.Bitmap? bg = null;
            try { bg = Properties.Resources.background; } catch { }

            if (bg == null)
            {
                set_FormBackground(sender, e);
                return;
            }

            e.Graphics.DrawImage(bg, new Rectangle(0, 0, panel.Width, panel.Height));

            // Semi-transparent green overlay for readability
            using var overlay = new SolidBrush(Color.FromArgb(150, 27, 94, 32));
            e.Graphics.FillRectangle(overlay, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        /// <summary>Styles a button in primary green style</summary>
        public static void StylePrimaryButton(Button btn)
        {
            btn.BackColor = PrimaryGreen;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) => btn.BackColor = AccentGreen;
            btn.MouseLeave += (s, e) => btn.BackColor = PrimaryGreen;
        }

        /// <summary>Styles a button in danger/delete style</summary>
        public static void StyleDangerButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(198, 40, 40);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(160, 30, 30);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(198, 40, 40);
        }

        /// <summary>Styles a button in neutral/navigation style</summary>
        public static void StyleSecondaryButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(120, 144, 156);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(96, 125, 139);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(120, 144, 156);
        }

        /// <summary>Styles a TextBox in flat modern style</summary>
        public static void StyleTextBox(TextBox tb)
        {
            tb.Font = new Font("Segoe UI", 11);
            tb.BackColor = Color.White;
            tb.ForeColor = TextDark;
            tb.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>Creates a rounded rectangle path for product cards</summary>
        public static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
