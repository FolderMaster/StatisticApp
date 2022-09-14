using System.IO;
using ExcelDataReader;

using StatisticApp.Model.Births;

namespace StatisticApp.Model
{
    public static class XlsxManager
    {
        public static BirthDataSet ReadBitrhDataSet(string filePath)
        {
            BirthDataSet result = new BirthDataSet();
            using (FileStream fileReader = File.Open(filePath, FileMode.OpenOrCreate))
            {
                using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(fileReader))
                {
                    reader.Read();
                    while (reader.Read())
                    {
                        result.Births.Add(new Birth(reader.GetString(1)));
                    }
                }
            }
            return result;
        }
    }
}
