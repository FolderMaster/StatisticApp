using System.Collections.Generic;
using System.Linq;

namespace PrimaryStatisticProcessingApp.Models.Graphs
{
    public class Graph
    {
        public List<Axis> Axises { get; set; } = new List<Axis>();

        public List<IShape> Shapes { get; set; } = new List<IShape>();

        public List<IShape> Displays
        {
            get
            {
                List<IShape> result = new List<IShape>();
                foreach(IShape shape in Shapes)
                {
                    result.Add(shape.Display(this));
                }
                return result;
            }
        }

        public double DefaultValue { get; set; } = 0;

        public Graph()
        {
        }

        public Graph(double defaultValue = 0)
        {
            DefaultValue = defaultValue;
        }

        public Graph(IEnumerable<Axis> axises, double defaultValue = 0)
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
                Axis axis = Axises[n];

                axis.Max = GetMax(n);
                axis.Max = axis.MaxFunction(axis.Max);

                axis.Min = GetMin(n);
                axis.Min = axis.MinFunction(axis.Min);
            }
        }
    }
}