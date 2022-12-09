using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using CsvHelper.Configuration;
using CsvHelper;

namespace PrimaryStatisticProcessingApp.Services.IO
{
    public static class CsvManager
    {
        public delegate T ReadObject<T>(CsvReader reader);

        public static List<T> Load<T>(string filePath, ReadObject<T> read)
        {
            List<T> result = new List<T>();
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
                        result.Add(read(reader));
                    }
                }
            }
            return result;
        }
    }
}