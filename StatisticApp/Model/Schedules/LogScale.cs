﻿using System;

namespace StatisticApp.Model.Schedules
{
    public class LogScale : IScale
    {
        public double Display(double value, double min, double max, double length) =>
            Math.Log10(value / min) / Math.Log10(max / min) * length;
    }
}