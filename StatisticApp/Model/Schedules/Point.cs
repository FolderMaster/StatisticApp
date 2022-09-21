using System.Collections.Generic;
using System.Linq;

namespace StatisticApp.Model.Schedules
{
    public class Point : IShape
    {
        public List<double> Coordinates { get; set; } = new List<double>();

        public Point()
        {
        }

        public Point(IEnumerable<double> coordinates)
        {
            Coordinates = coordinates.ToList();
        }

        public IShape Display(Schedule schedule)
        {
            List<double> coordinates = new List<double>();
            for (int n = 0; n < schedule.Axises.Count; ++n)
            {
                if(n < Coordinates.Count)
                {
                    coordinates.Add(schedule.Axises[n].Display(Coordinates[n]));
                }
                else
                {
                    coordinates.Add(schedule.DefaultValue);
                }
            }
            return new Point(coordinates);
        }

        public double GetMax(Schedule schedule, int axisIndex)
        {
            return axisIndex < Coordinates.Count ? Coordinates[axisIndex] : schedule.DefaultValue;
        }

        public double GetMin(Schedule schedule, int axisIndex)
        {
            return axisIndex < Coordinates.Count ? Coordinates[axisIndex] : schedule.DefaultValue;
        }

        public override string ToString()
        {
            return string.Join(";", Coordinates);
        }
    }
}
