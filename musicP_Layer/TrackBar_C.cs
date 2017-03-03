using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicP_Layer
{
    class TrackBar_C : Control
    {
        private int _Val;
        public event EventHandler ValChanged;
        protected virtual void OnValChanged()
        {
            ValChanged?.Invoke(this, EventArgs.Empty);
            Rect.X = Val * (this.Width - 25) / (Max - Min + 1) + 10;
            Invalidate();
        }
        public int Val
        {
            get
            {
                return _Val;
            }
            set
            {
                _Val = value;
                OnValChanged();
            }
        }
        public enum PointerStyleOption { circel, rectangle }
        PointerStyleOption _PointerStyle = PointerStyleOption.rectangle;
        public event EventHandler PointerStyleChanged;
        protected virtual void OnPointerStyleChanged()
        {
            PointerStyleChanged?.Invoke(this, EventArgs.Empty);
            DrawPointer();
            Rect.X = Val * (this.Width - 25) / (Max - Min + 1) + 10;
            Invalidate();
        }
        public PointerStyleOption PointerStyle
        {
            get
            {
                return _PointerStyle;
            }
            set
            {
                _PointerStyle = value;

            }
        }
        public int Max { get; set; }
        public int Min { get; set; }
        public int PointerCircleSize { get; set; }
        public int PointerInCircleDistence { get; set; }
        private Size _PointerRectSize = new Size(10, 20);
        public Size PointerRectSize { get { return _PointerRectSize; } set { _PointerRectSize = value; } }
        public Color BorderColor { get; set; }
        public Color PointerInColor { get; set; }
        public Color PointerOutColor { get; set; }
        private Bitmap Pointer;
        private Rectangle Rect = new Rectangle(5, 5, 20, 20);
        private bool Moving;
        private int Offset;
        public event EventHandler Scroll;
        public TrackBar_C()
        {
            Val = 0;
            Max = 10;
            Min = 0;
            BorderColor = Color.Gray;
            PointerInColor = Color.White;
            PointerOutColor = Color.Black;
            PointerCircleSize = 20;
            PointerInCircleDistence = 3;
            PointerRectSize = new Size(10, 20);
            PointerStyle = PointerStyleOption.rectangle;
            Rect = new Rectangle(10, 5, PointerCircleSize, PointerCircleSize);
            Pointer = new Bitmap(Rect.Size.Width, Rect.Height);
            Size = new Size(210, 50);
            DoubleBuffered = true;
            DrawPointer();
        }
        void DrawPointer()
        {
            switch (_PointerStyle)
            {
                case PointerStyleOption.circel:
                    Rect.Size = new Size(PointerCircleSize, PointerCircleSize);
                    Pointer = new Bitmap(Rect.Size.Width, Rect.Height);
                    using (Graphics g = Graphics.FromImage(Pointer))
                    {
                        g.Clear(Color.Transparent);
                        g.FillEllipse(new SolidBrush(PointerOutColor), new Rectangle(0, 0, PointerCircleSize, PointerCircleSize));
                        g.FillEllipse(new SolidBrush(PointerInColor), new Rectangle((int)(PointerInCircleDistence / Math.Sqrt(2)), (int)(PointerInCircleDistence / Math.Sqrt(2)), PointerCircleSize - PointerInCircleDistence, PointerCircleSize - PointerInCircleDistence));
                    }
                    goto default;
                case PointerStyleOption.rectangle:
                    Rect.Size = PointerRectSize;
                    Pointer = new Bitmap(Rect.Size.Width, Rect.Height);
                    using (Graphics g = Graphics.FromImage(Pointer))
                    {
                        g.Clear(Color.Transparent);
                        g.FillRectangle(new SolidBrush(PointerOutColor), new Rectangle(new Point(0, 0), PointerRectSize));
                        //g.DrawRectangle(new Pen(PointerOutColor, 1), new Rectangle(0, 0, PointerRectSize.Width - 1, PointerRectSize.Height - 1));
                    }
                    goto default;
                default:
                    break;
            }




        }
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawPointer();
            e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, Width, Height));
            using (Pen P = new Pen(new SolidBrush(BorderColor), 1))
            {
                P.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                e.Graphics.DrawRectangle(P, new Rectangle(1, 1, Width - 2, Height - 2));
            }
            using (Pen P = new Pen(new SolidBrush(ForeColor), 1))
            {
                P.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                e.Graphics.DrawLine(P, new Point(15, this.Height / 2), new Point(this.Width - 15, this.Height / 2));
            }
            Rect.Y = (int)(this.Height / 2) - PointerCircleSize / 2;
            e.Graphics.DrawImage(Pointer, Rect);
            base.OnPaint(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (Rect.Contains(e.Location))
            {
                Moving = true;
                Offset = e.Location.X - Rect.X;
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            Moving = false;
            base.OnMouseUp(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (Moving)
            {
                Scroll?.Invoke(this, EventArgs.Empty);
                Rect.X = Math.Min(Math.Max(e.Location.X - Offset, 5), this.Width - 25);
                Val = Math.Min((Rect.X - 5) * (Max - Min + 1) / (this.Width - 30),Max);
                Invalidate();
            }
            base.OnMouseMove(e);
        }

    }
}