using System.Collections.Generic;

namespace StatisticApp.Model.Schedules
{
    public class Line : IShape
    {
        public Point Begin { get; set; } = new Point();

        public Point End { get; set; } = new Point();

        public List<List<double>> Points
        {
            get
            {
                List<List<double>> result = new List<List<double>>();
                result.Add(Begin.Coordinates);
                result.Add(End.Coordinates);
                return result;
            }
            set
            {
                Begin.Coordinates = value[0];
                End.Coordinates = value[1];
            }
        }

        public Line()
        {
        }

        public Line(Point begin, Point end)
        {
            Begin = begin;
            End = end;
        }

        public IShape Display(Schedule schedule)
        {
            Point begin = new Point();
            Point end = new Point();

            for (int n = 0; n < schedule.Axises.Count; n++)
            {
                if (n < Begin.Coordinates.Count)
                {
                    begin.Coordinates.Add(schedule.Axises[n].Display(Begin.Coordinates[n]));
                }
                else
                {
                    begin.Coordinates.Add(schedule.DefaultValue);
                }

                if (n < End.Coordinates.Count)
                {
                    end.Coordinates.Add(schedule.Axises[n].Display(End.Coordinates[n]));
                }
                else
                {
                    end.Coordinates.Add(schedule.DefaultValue);
                }
            }
            return new Line(begin, end);
        }
    }
}
