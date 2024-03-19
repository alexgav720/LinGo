using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinGo
{
    public partial class LinearProgressBar : Control
    {

        public Color BorderColor { get; set; } = Color.DarkGray;
        public Color BackColorProgress { get; set; } = Color.Green;

        private int _value = 0;
        public int Value
        {
            get => _value;
            set
            {
                if (value >= ValueMinimum && value <= ValueMaximum)
                {
                    _value = value;
                    Invalidate();
                }
            }
        }

        private int _valueMinimum = 0;
        public int ValueMinimum
        {
            get => _valueMinimum;
            set
            {
                if (value < ValueMaximum)
                {
                    _valueMinimum = value;

                    if (_valueMinimum > Value)
                    {
                        Value = _valueMinimum;
                        Invalidate();
                    }
                }
                else
                {
                    value = _valueMinimum;
                }
            }
        }

        private int _valueMaximum = 100;
        public int ValueMaximum
        {
            get => _valueMaximum;
            set
            {
                if (value > ValueMinimum)
                {
                    _valueMaximum = value;
                    Invalidate();
                }
                else
                {
                    value = _valueMaximum;
                }
            }
        }

        public int Step { get; set; } = 10;


        public LinearProgressBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(200, 20);
            BackColor = Color.Gray;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rectBase = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectProgress = new Rectangle(
                rectBase.X,
                rectBase.Y,
                CalculateProgressRectSize(rectBase),
                rectBase.Height);

            int Rad = 10;
            GraphicsPath gpathBase = RoundedRectangle(rectBase, Rad);
            GraphicsPath gpathProgress = RoundedRectangle(rectProgress, Rad);

            // Рисуем основу
            DrawBase(graph, gpathBase);

            // Рисуем прогресс
            DrawProgress(graph, rectProgress, gpathProgress);

            // Рисуем обводку
            DrawBorder(graph, gpathBase);
        }

        private int CalculateProgressRectSize(Rectangle rect)
        {
            int margin = ValueMaximum - ValueMinimum;
            return rect.Width * Value / margin;
        }

        private void DrawBase(Graphics graph, GraphicsPath gpath)
        {
            graph.FillPath(new SolidBrush(BackColor), gpath);
        }

        private void DrawBorder(Graphics graph, GraphicsPath gpath)
        {
            graph.DrawPath(new Pen(BorderColor), gpath);
        }

        private void DrawProgress(Graphics graph, Rectangle rect, GraphicsPath gpath)
        {
            if (rect.Width > 0)
            {
                SolidBrush br = new SolidBrush(BackColorProgress);

                graph.DrawPath(new Pen(br), gpath);
                graph.FillPath(br, gpath);
            }
        }

        public static GraphicsPath RoundedRectangle(Rectangle rect, float RoundSize)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);

            gp.CloseFigure();

            return gp;
        }

        //public bool PerformStep()
        //{
        //    if (Value < ValueMaximum)
        //    {
        //        if (Value + Step >= ValueMaximum)
        //        {
        //            Value = ValueMaximum;
        //            return false;
        //        }
        //        else
        //        {
        //            Value += Step;
        //            return true;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public void ResetProgress()
        {
            Value = ValueMinimum;
        }

    }
}