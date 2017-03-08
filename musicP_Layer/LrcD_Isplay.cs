using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lrcP_Layer
{
    class LrcD_Isplay : Control
    {
        private string[] _lyric = { "Welcome to LrcD_Isplay", "Here will show out the Lyric"};
        private TimeSpan[] _time = { TimeSpan.Zero, new TimeSpan(0,0,1)};
        public event EventHandler LrcChanged;
        private int index = 0;
        private int last_index = 0;
        private int word_inter = 15;
        private bool no_lyric=true;
        protected virtual void onLrcChanged()
        {
            LrcChanged?.Invoke(this, EventArgs.Empty);
            Invalidate();
        }
        protected override void OnFontChanged(EventArgs e)
        {
            using ( Graphics g = Graphics.FromImage(new Bitmap(500,500)))
            {
                word_inter = (int)(g.MeasureString("test", Font).Height) + 5;
            }
            base.OnFontChanged(e);
        }
        private TimeSpan _maxTime = TimeSpan.MaxValue;
        private TimeSpan _minTIme = TimeSpan.Zero;
        private TimeSpan _nowTime = TimeSpan.Zero;
        private bool init_con = true;
        public string[] lyric
        {
            get { return _lyric; }
            set
            {
                if (value != null)
                {
                    if (_lyric[0] != value[0])
                    {
                        _lyric = value;
                        no_lyric = false;
                    }
                    foreach (var i in value)
                    {
                        //Console.WriteLine(i);
                    }
                }else
                {
                    
                    _lyric = new string[]{ "Welecome to LrcD_Isplay", "Here will show out the Lyric"};
                    no_lyric = true;
                }
                init_con = true;
                Invalidate();
                onLrcChanged();
            }
        }
        public TimeSpan[] time
        {
            get { return _time; }
            set
            {
                if (value != null)
                {
                    _time = value;
                    maxTime = _time.Last<TimeSpan>();
                    foreach (var i in value)
                    {
                        //Console.WriteLine(i);
                    }
                }else
                {
                    _time = new TimeSpan[] { TimeSpan.Zero, new TimeSpan(0, 0, 1) };
                }
                nowTime = new TimeSpan(minTime.Ticks);
            }
        }
        public TimeSpan maxTime
        {
            get { return _maxTime; }
            set { _maxTime = value; }
        }
        public TimeSpan minTime
        {
            get { return _minTIme; }
            set {
                _minTIme = value;
            }
        }
        public TimeSpan nowTime
        {
            get { return _nowTime; }
            set {
                _nowTime = value;
                for (int i = 0; i < _time.Length-1; i++)
                {
                    //Console.WriteLine(value+"  "+_time[i]);
                    if (value > _time[i] && value < _time[i + 1]) 
                    {
                        //Console.WriteLine(i);
                        last_index = index;
                        index = i;
                        break;
                    }
                }
                //Console.WriteLine(index);
                if (index < _time.Length && index > 0 &&(last_index!=index))
                {
                    lrc_Area_Point.Y = (int)(-index * word_inter + (Size.Height / 2) + time_string_size.Height / 2);
                    draw_lrc();
                    Invalidate();
                }

            }
        }

        private Bitmap lrc_Area;
        private Rectangle lrc_Rect;
        private Point lrc_Area_Point = new Point();
        private bool druging = false;
        private Color _HighlightColor = Color.GreenYellow;
        public Color HighlightColor
        {
            get { return _HighlightColor; }
            set { _HighlightColor = value; }
        }


        public LrcD_Isplay()
        {
            lrc_Area_Point = new Point(0, Size.Height / 2);
        }
        private void draw_lrc()
        {
            //Console.WriteLine("upg");
            if (lrc_Area != null)
            {
                lrc_Area.Dispose();
            }
            lrc_Rect = new Rectangle(lrc_Area_Point, new Size(Size.Width, word_inter * lyric.Length));
            lrc_Area = new Bitmap(Size.Width, word_inter * lyric.Length);
            using (Graphics g = Graphics.FromImage(lrc_Area))
            {
                //g.FillRectangle(new SolidBrush(Color.Gray), new Rectangle(new Point(0, 0), lrc_Rect.Size));
                for (int i = 0; i < lyric.Length; i++)
                {
                    SizeF s = g.MeasureString(lyric[i], Font);
                    if (i == index)
                    {
                        g.DrawString(lyric[i], Font, new SolidBrush(HighlightColor), new Point((Size.Width / 2) - (int)(s.Width / 2), i * word_inter));
                    }
                    else{
                        g.DrawString(lyric[i], Font, new SolidBrush(ForeColor), new Point((Size.Width / 2) - (int)(s.Width / 2), i * word_inter));
                    }
                    
                }
            }
        }

        SizeF time_string_size = new SizeF();
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(new Point(0, 0), Size));
            if (init_con)
            {
                draw_lrc();
                init_con = false;
            }
            lrc_Rect.Location = lrc_Area_Point;
            e.Graphics.DrawImage(lrc_Area, lrc_Rect);
            if (druging)
            {
                string time_string = string.Format("{0:mm}:{0:ss}", nowTime);
                time_string_size = e.Graphics.MeasureString(time_string, Font);
                e.Graphics.DrawString(time_string, Font, new SolidBrush(ForeColor), new Point(5, Size.Height / 2));
                e.Graphics.DrawLine(new Pen(ForeColor), new Point((int)(time_string_size.Width+5),(int)(Size.Height/2+time_string_size.Height/2)), new Point(Size.Width, (int)(Size.Height / 2 + time_string_size.Height / 2)));
            }
                
            base.OnPaint(e);
        }
        private int offset = 0;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            Console.WriteLine(no_lyric);
            if (!no_lyric)
                druging = true;
            else
                druging = false;
            offset = e.Location.Y-lrc_Area_Point.Y;
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {

            if (druging)
            {
                lrc_Area_Point.Y = e.Location.Y-offset ;
                index = (int)(((Size.Height / 2) - lrc_Area_Point.Y + time_string_size.Height / 2) / word_inter);
                if (index < _time.Length && index > 0)
                {
                    //Console.WriteLine(index + "   " + _time[index]);
                    _nowTime = _time[index];
                }

                Invalidate();
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            druging = false;
            Invalidate();
            base.OnMouseUp(e);
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            lrc_Area_Point = new Point(0, Size.Height / 2);
            Invalidate();
            base.OnVisibleChanged(e);
        }
        protected override void OnResize(EventArgs e)
        {
            Invalidate();
            lrc_Area_Point.Y = (int)(-index * word_inter + (Size.Height / 2) + time_string_size.Height / 2);
            init_con = true;
            base.OnResize(e);
        }
    }
}
