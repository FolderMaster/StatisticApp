using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using StatisticApp.Model.Schedules;

using Point = StatisticApp.Model.Schedules.Point;

namespace StatisticApp.View.Controls
{
    public partial class DisplayControl : UserControl
    {
        private Schedule _schedule = new Schedule();

        public int PointSize { get; set; } = 10;

        public int LineXSize { get; set; } = 20;

        public int LineYSize { get; set; } = 20;

        public Font ValueFont { get; set; } = new Font(FontFamily.GenericSansSerif, 10,
            FontStyle.Regular);

        public SolidBrush FontBrush { get; set; } = new SolidBrush(Color.Black);

        public Pen AxisXPen { get; set; } = new Pen(Color.Black);

        public Pen AxisYPen { get; set; } = new Pen(Color.Black);

        public Pen LinePen { get; set; } = new Pen(Color.Black);

        public Pen LineXPen { get; set; } = new Pen(Color.Black);

        public Pen LineYPen { get; set; } = new Pen(Color.Black);

        public SolidBrush InnerPointBrush { get; set; } = new SolidBrush(Color.Gray);

        public Pen OuterPointPen { get; set; } = new Pen(Color.Black);

        public Schedule Schedule
        {
            get
            {
                return _schedule;
            }
            set
            {
                _schedule = value;
                _schedule.Axises[0].Length = Width;
                _schedule.Axises[1].Length = Height;
            }
        }

        public DisplayControl()
        {
            InitializeComponent();

            _schedule.Axises.Add(new Axis(new LogScale(), Width));
            _schedule.Axises.Add(new Axis(new LinearScale(), Height));
        }

        private void Canvas_SizeChanged(object sender, EventArgs e)
        {
            _schedule.Axises[0].Length = Width;
            _schedule.Axises[1].Length = Height;

            Canvas.Invalidate();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = Canvas.CreateGraphics();

            graphics.DrawLine(AxisXPen, 0, Height - 1, Width, Height - 1);
            graphics.DrawLine(AxisYPen, 0, 0, 0, Height);

            List <IShape> display = _schedule.Displays;
            List <IShape> shapes = _schedule.Shapes;
            for (int n = 0; n < display.Count; ++n)
            {
                if(display[n] is Point point)
                {
                    int x = (int)point.Coordinates[0];
                    int y = (int)point.Coordinates[1];
                    
                    Point values = shapes[n] as Point;
                    graphics.DrawLine(LineXPen, x, Height, x, Height - LineXSize);
                    graphics.DrawString(values.Coordinates[0].ToString(), ValueFont, FontBrush,
                        x, Height - LineXSize);

                    graphics.DrawLine(LineYPen, 0, Height - y, LineYSize, Height - y);
                    graphics.DrawString(values.Coordinates[1].ToString(), ValueFont, FontBrush,
                        LineYSize, Height - y);

                    graphics.DrawEllipse(OuterPointPen, x - PointSize / 2, Height - y - PointSize
                        / 2, PointSize, PointSize);
                    graphics.FillEllipse(InnerPointBrush, x - PointSize / 2, Height - y - PointSize
                        / 2, PointSize, PointSize);
                }
                else if (display[n] is Line line)
                {
                    int x1 = (int)line.Begin.Coordinates[0];
                    int y1 = (int)line.Begin.Coordinates[1];
                    int x2 = (int)line.End.Coordinates[0];
                    int y2 = (int)line.End.Coordinates[1];

                    graphics.DrawLine(LinePen, x1, Height - y1, x2, Height - y2);

                    Line values = shapes[n] as Line;
                    graphics.DrawString(values.Begin.Coordinates[1].ToString(), ValueFont,
                        FontBrush, (x1 + x2) / 2, Height - (y1 + y2) / 2);
                }
            }
        }
    }
}