using System.Drawing;

namespace WinFormsApp5
{
    internal static class Theme
    {
        public static readonly Color OuterBackground = Color.FromArgb(0xE5, 0xE5, 0xE5);
        public static readonly Color SidebarBackground = Color.FromArgb(0x1B, 0x25, 0x40);
        public static readonly Color White = Color.White;
        public static readonly Color PrimaryBlue = Color.FromArgb(0x2F, 0x6F, 0xED);
        public static readonly Color PrimaryBlueHover = Color.FromArgb(0x28, 0x60, 0xD4);
        public static readonly Color PrimaryBluePressed = Color.FromArgb(0x21, 0x52, 0xB7);
        public static readonly Color DisabledBlue = Color.FromArgb(0x9B, 0xB7, 0xF2);
        public static readonly Color Green = Color.FromArgb(0x3D, 0xD6, 0x8C);
        public static readonly Color MainText = Color.FromArgb(0x1F, 0x29, 0x37);
        public static readonly Color MutedText = Color.FromArgb(0x64, 0x70, 0x8A);
        public static readonly Color InputBorder = Color.FromArgb(0xCA, 0xD3, 0xE2);
        public static readonly Color SidebarText = Color.FromArgb(0xC4, 0xCC, 0xDD);
        public static readonly Color SidebarHeading = Color.FromArgb(0x9D, 0xB7, 0xFF);

        public const int ReferenceWidth = 900;
        public const int ReferenceHeight = 562;
        public const int SidebarWidth = 375;
        public const int ContentPadding = 41;
        public const int LoginColumnWidth = 420;

        public static Font Font(float size, FontStyle style = FontStyle.Regular) =>
            new Font("Segoe UI", size, style, GraphicsUnit.Point);
    }
}
