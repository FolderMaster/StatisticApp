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
            if (Shapes.Count == 0)
            {
                return DefaultValue;
            }
            else
            {
                List<double> coordinates = new List<double>();
                foreach (IShape shape in Shapes)
                {
                    coordinates.Add(shape.GetMin(this, axisesIndex));
                }
                return coordinates.Min();
            }
        }

        public double GetMax(int axisesIndex)
        {
            if (Shapes.Count == 0)
            {
                return DefaultValue;
            }
            else
            {
                List<double> coordinates = new List<double>();
                foreach (IShape shape in Shapes)
                {
                    coordinates.Add(shape.GetMax(this, axisesIndex));
                }
                return coordinates.Max();
            }
        }

        public void DefaultDisplay()
        {
            for(int n = 0; n < Axises.Count; ++n)
            {
                Axises[n].Max = GetMax(n);
                Axises[n].Min = GetMin(n);
            }
        }
    }
}