using System.Globalization;

using PrimaryStatisticProcessingApp.Models;
using PrimaryStatisticProcessingApp.Services.IO;
using static PrimaryStatisticProcessingApp.Services.IO.CsvManager;

namespace PrimaryStatisticProcessingApp.Services.Factories
{
    public static class SampleFactory
    {
        private static ReadObject<(int, double)> ReadIdValue { get; } = (reader) =>
        {
            int id = int.Parse(reader.GetField(""));
            double value = double.Parse(reader.GetField("BMI"), CultureInfo.GetCultureInfo("en-US"));
            return (id, value);
        };

        public static Sample LoadSample(string filePath)
        {
            return new Sample(CsvManager.Load(filePath, ReadIdValue));
        }
    }
}