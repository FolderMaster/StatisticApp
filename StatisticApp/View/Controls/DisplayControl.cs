using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StatisticApp.Model.Shedules;

namespace StatisticApp.View.Controls
{
    public partial class DisplayControl : UserControl
    {
        private Schedule _schedule = new Schedule();

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

            _schedule.Axises.Add(new Axis(new LogScale(), (double)Width));
            _schedule.Axises.Add(new Axis(new LinearScale(), (double)Height));
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
            Pen pen = new Pen(ColorManager.UsualColor);
            graphics.DrawLine(pen, 0, 0, Width, 0);
            graphics.DrawLine(pen, 0, 0, 0, Height);
            for (int n = 0; n < _schedule.Count; ++n)
            {
                double x = _schedule.Axises[0].Displays[n];
                double y = _schedule.Axises[1].Displays[n];
                graphics.DrawLine(pen, (int)x, 0, (int)x, size);
                graphics.DrawLine(pen, 0, (int)y, size, (int)y);
                graphics.DrawEllipse(pen, (int)x - size / 2, (int)y - size / 2, size, size);
            }
        }
    }
}
