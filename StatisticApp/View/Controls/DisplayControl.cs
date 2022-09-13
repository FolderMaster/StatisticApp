using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using StatisticApp.Model.Schedules;

namespace StatisticApp.View.Controls
{
    public partial class DisplayControl : UserControl
    {
        private Schedule _schedule = new Schedule();

        public Color InnerPointerColor = Color.Gray;

        public Color OuterPointerColor = Color.Black;

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
            const int size = 10;
            Graphics graphics = Canvas.CreateGraphics();

            Pen pen = new Pen(OuterPointerColor);
            SolidBrush brush = new SolidBrush(InnerPointerColor);

            graphics.DrawLine(pen, 0, Height - 1, Width, Height - 1);
            graphics.DrawLine(pen, 0, 0, 0, Height);

            List <IShape> shapes = _schedule.Displays;
            for (int n = 0; n < shapes.Count; ++n)
            {
                if(shapes[n].Points.Count == 1)
                {
                    int x = (int)shapes[n].Points[0][0];
                    int y = (int)shapes[n].Points[0][1];
                    
                    graphics.DrawLine(pen, x, Height, x, Height - size);
                    graphics.DrawLine(pen, 0, Height - y, size, Height - y);

                    graphics.DrawEllipse(pen, x - size / 2, Height - y - size / 2, size, size);
                    graphics.FillEllipse(brush, x - size / 2, Height -  y - size / 2, size, size);
                }
                else if (shapes[n].Points.Count == 2)
                {
                    int x1 = (int)shapes[n].Points[0][0];
                    int y1 = (int)shapes[n].Points[0][1];
                    int x2 = (int)shapes[n].Points[1][0];
                    int y2 = (int)shapes[n].Points[1][1];

                    graphics.DrawLine(pen, x1, Height - y1, x2, Height - y2);
                }
                
            }
        }
    }
}
