using System.Collections.Generic;
using System.Linq;

namespace StatisticApp.Model.Shedules
{
    public class Axis
    {
        public IScale Scale { get; set; } = new LinearScale();

        public List<double> Values { get; set; } = new List<double>();

        public double Length { get; set; } = 0;

        public List<double> Displays
        {
            get
            {
                double max = Max * 1.1;
                double min = Min * 0.9;
                List<double> result = new List<double>();
                foreach(var value in Values)
                {
                    result.Add(Scale.Display(value, min, max, Length));
                }
                return result;
            }
        }

        public double Min
        {
            get
            {
                return Enumerable.Min(Values);
            }
        }

        public double Max
        {
            get
            {
                return Enumerable.Max(Values);
            }
        }

        public Axis()
        {
        }

        public Axis(IScale scale, double lenght = 0)
        {
            Scale = scale;
            Length = lenght;
        }

        public Axis(IScale scale, IEnumerable<double> values, double length = 0)
        {
            Scale = scale;
            Values = values.ToList();
            Length = length;
        }
    }
}
