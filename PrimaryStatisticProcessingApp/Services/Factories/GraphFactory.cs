using System.Collections.Generic;
using PrimaryStatisticProcessingApp.Models;
using PrimaryStatisticProcessingApp.Models.Graphs;

namespace PrimaryStatisticProcessingApp.Services.Factories
{
    public static class GraphFactory
    {
        public static Graph CreateBarChartBySample(Sample sample)
        {
            Graph result = new Graph(new List<Axis>() {
                new Axis(new LinearScale(), (min) => min - 10, (max) => max + 10), 
                new Axis(new LinearScale(), (min) => min - 10, (max) => max + 10) });
            List<(double, double,  int)> barChart = sample.BarChart;
            foreach((double, double, int) value in barChart)
            {
                result.Shapes.Add(new Rectangle(
                    new Point(new List<double>() { value.Item1, 0 }),
                    new Point(new List<double>() { value.Item2, value.Item3 })));
            }
            return result;
        }
    }
}