namespace StatisticApp.Model.Schedules
{
    public class Axis
    {
        private double _min = 0;

        private double _max = 0;

        public delegate double Function(double value);

        public IScale Scale { get; set; } = new LinearScale();

        public double Length { get; set; } = 0;

        public double Min
        {
            get
            {
                return MinFunction(_min);
            }
            set
            {
                _min = value;
            }
        }

        public double Max
        {
            get
            {
                return MaxFunction(_max);
            }
            set
            {
                _max = value;
            }
        }

        public Function MinFunction { get; set; } = (value) => value;

        public Function MaxFunction { get; set; } = (value) => value;

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

        public Axis(IScale scale, Function minFunction, Function maxFunction, double length = 0,
            double min = 0, double max = 0)
        {
            Scale = scale;
            Length = length;
            Min = min;
            Max = max;
            MinFunction = minFunction;
            MaxFunction = maxFunction;
        }

        public double Display(double value)
        {
            return Scale.Display(value, Min, Max, Length);
        }
    }
}