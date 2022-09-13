using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace StatisticApp.Model.Schedules
{
    public class Schedule
    {
        public List<Axis> Axises { get; set; } = new List<Axis>();

        public List<IShape> Shapes { get; set; } = new List<IShape>();

        public List<IShape> Displays
        {
            get
            {
                List<IShape> result = new List<IShape>();
                for (int a = 0; a < Axises.Count; ++a)
                {
                    Axises[a].Min = GetMin(a);
                    Axises[a].Max = GetMax(a);
                }
                for(int n = 0; n < Shapes.Count; ++n)
                {
                    result.Add(Shapes[n].Display(this));
                }
                return result;
            }
        }

        public double DefaultValue { get; set; } = 0;

        public Schedule()
        {
        }

        public Schedule(double defaultValue = 0)
        {
            DefaultValue = defaultValue;
        }

        public Schedule(IEnumerable<Axis> axises, double defaultValue = 0)
        {
            Axises = axises.ToList();
            DefaultValue = defaultValue;
        }

        public double GetMin(int axisesIndex)
        {
            double result = DefaultValue;
            List<double> coordinates = GetCoordinates(axisesIndex);
            if(coordinates.Count != 0)
            {
                result = coordinates.Min();
            }
            return result;
        }

        public double GetMax(int axisesIndex)
        {
            double result = DefaultValue;
            List<double> coordinates = GetCoordinates(axisesIndex);
            if (coordinates.Count != 0)
            {
                result = coordinates.Max();
            }
            return result;
        }

        private List<double> GetCoordinates(int axiseIndex)
        {
            List<double> result = new List<double>();
            for (int s = 0; s < Shapes.Count; ++s)
            {
                for (int p = 0; p < Shapes[s].Points.Count; ++p)
                {
                    if (axiseIndex < Shapes[s].Points[p].Count)
                    {
                        result.Add(Shapes[s].Points[p][axiseIndex]);
                    }
                    else
                    {
                        result.Add(DefaultValue);
                    }
                }
            }
            return result;
        }
    }
}