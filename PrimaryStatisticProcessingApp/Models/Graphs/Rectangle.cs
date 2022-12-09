namespace PrimaryStatisticProcessingApp.Models.Graphs
{
    public class Rectangle : IShape
    {
        public Point Point1 { get; set; } = new Point();

        public Point Point2 { get; set; } = new Point();

        public Rectangle()
        {
        }

        public Rectangle(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public IShape Display(Graph schedule)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            for (int n = 0; n < schedule.Axises.Count; ++n)
            {
                if (n < Point1.AxisCount)
                {
                    point1.Coordinates.Add(schedule.Axises[n].Display(Point1[n]));
                }
                else
                {
                    point1.Coordinates.Add(schedule.DefaultValue);
                }

                if (n < Point2.AxisCount)
                {
                    point2.Coordinates.Add(schedule.Axises[n].Display(Point2[n]));
                }
                else
                {
                    point2.Coordinates.Add(schedule.DefaultValue);
                }
            }
            return new Rectangle(point1, point2);
        }

        public double GetMax(Graph schedule, int axisIndex)
        {
            double point1 = axisIndex < Point1.AxisCount ? Point1[axisIndex] : 
                schedule.DefaultValue;
            double point2 = axisIndex < Point2.AxisCount ? Point2[axisIndex] :
                schedule.DefaultValue;
            return point1 > point2 ? point1 : point2;
        }

        public double GetMin(Graph schedule, int axisIndex)
        {
            double point1 = axisIndex < Point1.AxisCount ? Point1[axisIndex] :
                schedule.DefaultValue;
            double point2 = axisIndex < Point2.AxisCount ? Point2[axisIndex] :
                schedule.DefaultValue;
            return point1 < point2 ? point1 : point2;
        }
    }
}