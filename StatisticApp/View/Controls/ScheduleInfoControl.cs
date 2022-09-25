using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using StatisticApp.Model.Schedules;

using Point = StatisticApp.Model.Schedules.Point;

namespace StatisticApp.View.Controls
{
    public partial class ScheduleInfoControl : UserControl
    {
        private List<IShape> _shapes = new List<IShape>();

        public List<IShape> Shapes
        {
            get => _shapes;
            set
            {
                _shapes = value;
                Fill();
            }
        }

        public ScheduleInfoControl()
        {
            InitializeComponent();
        }

        public void Fill()
        {
            List<Point> points = new List<Point>();
            List<LineSegment> lineSegments = new List<LineSegment>();
            foreach(IShape shape in Shapes)
            {
                if(shape is Point point)
                {
                    points.Add(point);
                }
                else if(shape is LineSegment lineSegment)
                {
                    lineSegments.Add(lineSegment);
                }
            }

            points.Sort();
            lineSegments.Sort();
            PointsTextBox.Text = string.Join("\r\n", points);
            LineSegmentsTextBox.Text = string.Join("\r\n", lineSegments);
        }
    }
}
