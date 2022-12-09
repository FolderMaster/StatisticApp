using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimaryStatisticProcessingApp.Models
{
    public class Sample
    {
        public List<(int, double)> IdValues { get; set; } = new List<(int, double)>();

        public Sample SortedSample
        {
            get => new Sample(IdValues.OrderBy((iv) => iv.Item2).ToList());
        }

        public int Count
        {
            get => IdValues.Count;
        }

        public double Max
        {
            get => IdValues.Max((iv) => iv.Item2);
        }

        public double Min
        {
            get => IdValues.Min((iv) => iv.Item2);
        }

        public double Range
        {
            get => Max - Min;
        }

        public int IntervalCount
        {
            get => 1 + (int)Math.Log(Count, 2);
        }

        public double IntervalRange
        {
            get => Range / (double)IntervalCount;
        }

        public List<(double, double, int)> BarChart
        {
            get
            {
                Sample sortedSample = SortedSample;
                double intervalMax = Min + IntervalRange;
                double intervalMin = Min;
                List<(double, double, int)> result = new List<(double, double, int)>
                {
                    (intervalMin, intervalMax, 0)
                };
                for (int n = 0; n < sortedSample.Count; ++n)
                {
                    if (sortedSample.IdValues[n].Item2 > intervalMax)
                    {
                        intervalMin = intervalMax;
                        intervalMax += IntervalRange;
                        result.Add((intervalMin, intervalMax, 0));
                    }
                    (double, double, int) value = result[result.Count - 1];
                    ++value.Item3;
                    result[result.Count - 1] = value;
                }
                return result;
            }
        }

        public List<(double, int)> VariationalTable
        {
            get
            {
                Sample sortedSample = SortedSample;
                List<(double, int)> result = new List<(double, int)>();
                double intervalMax = Min + IntervalRange;
                double intervalMin = Min;
                result.Add(((intervalMin + intervalMax) / (double)2, 0));
                for (int n = 0; n < sortedSample.Count; ++n)
                {
                    if (sortedSample.IdValues[n].Item2 > intervalMax)
                    {
                        intervalMin = intervalMax;
                        intervalMax += IntervalRange;
                        result.Add(((intervalMin + intervalMax) / (double)2, 0));
                    }
                    (double, int) value = result[result.Count - 1];
                    ++value.Item2;
                    result[result.Count - 1] = value;
                }
                return result;
            }
        }

        public double Mean
        {
            get => GetIntialMoment(1);
        }

        public double Median
        {
            get
            {
                Sample sortedSample = SortedSample;
                double result;
                int index = (sortedSample.Count - 1) / 2;
                if (sortedSample.Count % 2 == 1)
                {
                    result = sortedSample.IdValues[index + 1].Item2;
                }
                else
                {
                    result = (sortedSample.IdValues[index].Item2 + sortedSample.
                        IdValues[index + 1].Item2) / (double)2;
                }
                return result;
            }
        }

        public double Variance
        {
            get => GetCentralMoment(2);
        }

        public double StandardDeviation
        {
            get => Math.Sqrt(Variance);
        }

        public double ThirdOrderMoment
        {
            get => GetCentralMoment(3);
        }

        public double FourthOrderMoment
        {
            get => GetCentralMoment(4);
        }

        public double Asymmetry
        {
            get => ThirdOrderMoment / Math.Pow(StandardDeviation, 3);
        }

        public double Excess
        {
            get => FourthOrderMoment / Math.Pow(StandardDeviation, 4) - 3;
        }

        public Sample()
        {
        }

        public Sample(List<(int, double)> idValues)
        {
            IdValues = idValues;
        }

        private double GetIntialMoment(int order)
        {
            List<(double, int)> variationalTable = VariationalTable;
            double result = 0;
            foreach ((double, int) pair in variationalTable)
            {
                result += Math.Pow(pair.Item1, order) * pair.Item2;
            }
            result /= Count;
            return result;
        }

        private double GetCentralMoment(int order)
        {
            List<(double, int)> variationalTable = VariationalTable;
            double result = 0;
            foreach ((double, int) pair in variationalTable)
            {
                result += Math.Pow(pair.Item1 - Mean, order) * pair.Item2;
            }
            result /= Count;
            return result;
        }
    }
}