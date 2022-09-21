using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using StatisticApp.Model.Schedules;

using Point = StatisticApp.Model.Schedules.Point;
using StatisticApp.Model;
using StatisticApp.View.Forms;

namespace StatisticApp.View.Controls
{
    public partial class DisplayControl : UserControl
    {
        private Schedule _schedule;

        private SettingsFormat _settings;

        public Schedule Schedule
        {
            get
            {
                return _schedule;
            }
            set
            {
                if(value != null)
                {
                    if (value.Axises.Count >= 2)
                    {
                        _schedule = value;
                        _schedule.Axises[0].Length = Width;
                        _schedule.Axises[1].Length = Height;

                        Canvas.Invalidate();
                    }
                }
            }
        }

        public SettingsFormat Settings
        {
            get
            {
                return _settings;
            }
            set
            {
                _settings = value;

                Canvas.Invalidate();
            }
        }

        public DisplayControl()
        {
            InitializeComponent();

            Schedule = new Schedule(new List<Axis>() {
                new Axis(new LinearScale()), new Axis(new LinearScale()) });
            Settings = new SettingsFormat();
        }

        public void DefaultDisplay()
        {
            Schedule.DefaultDisplay();

            Canvas.Invalidate();
        }

        private void Canvas_SizeChanged(object sender, EventArgs e)
        {
            Schedule.Axises[0].Length = Width;
            Schedule.Axises[1].Length = Height;

            Canvas.Invalidate();
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            InfoForm infoForm = new InfoForm(Schedule.Shapes);
            infoForm.ShowDialog();
        }

        private void Canvas_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Canvas_MouseWheel(object sender, MouseEventArgs e)
        {
            Schedule.Axises[0].Max += e.Delta * (e.X - Width / 2);
            Schedule.Axises[0].Min += e.Delta * (e.X - Width / 2);
            Schedule.Axises[1].Min += e.Delta * (Height / 2 - e.Y);
            Schedule.Axises[1].Max += e.Delta * (Height / 2 - e.Y);

            Canvas.Invalidate();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = Canvas.CreateGraphics();

            graphics.DrawLine(Settings.AxisXPen, 0, Height - 1, Width, Height - 1);
            graphics.DrawLine(Settings.AxisYPen, 0, 0, 0, Height);

            List<IShape> display = Schedule.Displays;
            List<IShape> shapes = Schedule.Shapes;
            for (int n = 0; n < display.Count; ++n)
            {
                if (display[n] is Point point)
                {
                    int x = (int)point.Coordinates[0];
                    int y = (int)point.Coordinates[1];

                    Point values = shapes[n] as Point;
                    graphics.DrawLine(Settings.LineXPen, x, Height, x, Height - Settings.LineXSize);
                    graphics.DrawString(values.Coordinates[0].ToString(), Settings.ValueFont,
                        Settings.FontSolidBrush, x, Height - Settings.LineXSize);

                    graphics.DrawLine(Settings.LineYPen, 0, Height - y, Settings.LineYSize,
                        Height - y);
                    graphics.DrawString(values.Coordinates[1].ToString(), Settings.ValueFont,
                        Settings.FontSolidBrush, Settings.LineYSize, Height - y);

                    graphics.DrawEllipse(Settings.OuterPointPen, x - Settings.PointSize / 2, Height
                        - y - Settings.PointSize / 2, Settings.PointSize, Settings.PointSize);
                    graphics.FillEllipse(Settings.InnerPointSolidBrush, x - Settings.PointSize / 2,
                        Height - y - Settings.PointSize/ 2, Settings.PointSize, Settings.PointSize);
                }
                else if (display[n] is LineSegment lineSegment)
                {
                    int x1 = (int)lineSegment.Begin.Coordinates[0];
                    int y1 = (int)lineSegment.Begin.Coordinates[1];
                    int x2 = (int)lineSegment.End.Coordinates[0];
                    int y2 = (int)lineSegment.End.Coordinates[1];

                    graphics.DrawLine(Settings.LinePen, x1, Height - y1, x2, Height - y2);

                    LineSegment values = shapes[n] as LineSegment;
                    graphics.DrawString(values.Begin.Coordinates[1].ToString(), Settings.ValueFont,
                        Settings.FontSolidBrush, (x1 + x2) / 2, Height - (y1 + y2) / 2);
                }
            }
        }
    }
}