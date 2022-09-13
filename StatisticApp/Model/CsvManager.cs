using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

using StatisticApp.Model.Births;

namespace StatisticApp.Model
{
    public static class CsvManager
    {
        public static BirthDataSet ReadBitrhDataSet(string filePath)
        {
            BirthDataSet result = new BirthDataSet();
            using (StreamReader streamReader = new StreamReader(filePath, Encoding.UTF8))
            {
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Encoding = Encoding.UTF8,
                    Delimiter = ","
                };

                using (CsvReader reader = new CsvReader(streamReader, configuration))
                {
                    reader.Read();
                    reader.ReadHeader();
                    while (reader.Read())
                    {
                        result.Births.Add(new Birth(reader.GetField("SEX")));
                    }
                }
            }
            return result;
        }
    }
}