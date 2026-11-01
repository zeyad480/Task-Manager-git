using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace WinFormsApp5
{
    internal sealed class RoundedTextBox : UserControl
    {
        private readonly TextBox textBox;
        private int cornerRadius = 8;

        public RoundedTextBox()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            BackColor = Theme.White;
            ForeColor = Theme.MainText;
            Height = 40;
            Padding = new Padding(11, 1, 11, 1);

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                Font = Theme.Font(14),
                ForeColor = Theme.MainText,
                BackColor = Theme.White,
                Margin = Padding.Empty,
                TabStop = true
            };
            textBox.TextChanged += (_, _) => Invalidate();
            Controls.Add(textBox);
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public bool UseSystemPasswordChar
        {
            get => textBox.UseSystemPasswordChar;
            set => textBox.UseSystemPasswordChar = value;
        }

        public TextBox InnerTextBox => textBox;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var path = CreateRoundedPath(ClientRectangle, cornerRadius);
            using var pen = new Pen(Theme.InputBorder, 1);
            e.Graphics.DrawPath(pen, path);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        private static GraphicsPath CreateRoundedPath(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            int diameter = radius * 2;
            var arc = new Rectangle(bounds.X, bounds.Y, diameter, diameter);
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.X;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }
    }

    internal sealed class RoundedButton : Button
    {
        private bool isHovered;
        private bool isPressed;
        private int cornerRadius = 8;

        public RoundedButton()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Theme.PrimaryBlue;
            ForeColor = Theme.White;
            Font = Theme.Font(13, FontStyle.Bold);
            Cursor = Cursors.Hand;
            Height = 41;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            isHovered = true;
            Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            isHovered = false;
            isPressed = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            isPressed = true;
            Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            isPressed = false;
            Invalidate();
            base.OnMouseUp(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var color = !Enabled ? Theme.DisabledBlue :
                isPressed ? Theme.PrimaryBluePressed :
                isHovered ? Theme.PrimaryBlueHover : Theme.PrimaryBlue;
            using var path = CreateRoundedPath(ClientRectangle, cornerRadius);
            using var brush = new SolidBrush(color);
            e.Graphics.FillPath(brush, path);
            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
        }

        private static GraphicsPath CreateRoundedPath(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            int diameter = radius * 2;
            var arc = new Rectangle(bounds.X, bounds.Y, diameter, diameter);
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.X;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
