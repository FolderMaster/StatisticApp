namespace StatisticApp.Model.Schedules
{
    public class Axis
    {
        public IScale Scale { get; set; } = new LinearScale();

        public double Min { get; set; } = 0;

        public double Max { get; set; } = 0;

        public double Length { get; set; } = 0;

        public Axis()
        {
        }

        public Axis(double lenght = 0, double min = 0, double max = 0)
        {
            Length = lenght;
            Min = min;
            Max = max;
        }

        public Axis(IScale scale, double lenght = 0, double min = 0, double max = 0)
        {
            Scale = scale;
            Length = lenght;
            Min = min;
            Max = max;
        }

        public double Display(double value)
        {
            return Scale.Display(value, Min, Max, Length);
        }
    }
}