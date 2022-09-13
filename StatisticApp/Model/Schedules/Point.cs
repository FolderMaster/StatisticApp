using System.Collections.Generic;
using System.Linq;

namespace StatisticApp.Model.Schedules
{
    public class Point : IShape
    {
        public List<double> Coordinates { get; set; } = new List<double>();

        public List<List<double>> Points
        {
            get
            {
                List<List<double>> result = new List<List<double>>();
                result.Add(Coordinates);
                return result;
            }
            set
            {
                Coordinates = value[0];
            }
        }

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
            for (int n = 0; n < schedule.Axises.Count; n++)
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
    }
}
