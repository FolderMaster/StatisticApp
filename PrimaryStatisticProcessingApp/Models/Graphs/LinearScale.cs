namespace PrimaryStatisticProcessingApp.Models.Graphs
{
    public class LinearScale: IScale
    {
        public double Display(double value, double min, double max, double length) =>
            (value - min) / (max - min) * length;
    }
}