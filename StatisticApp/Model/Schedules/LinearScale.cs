﻿namespace StatisticApp.Model.Shedules
{
    public class LinearScale: IScale
    {
        public double Display(double value, double min, double max, double length) => (value - min) / (max - min) * length;
    }
}