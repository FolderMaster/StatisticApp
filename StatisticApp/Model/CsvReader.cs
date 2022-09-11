using Microsoft.VisualBasic.FileIO;

using StatisticApp.Model.Births;

namespace StatisticApp.Model
{
    public static class CsvReader
    {
        public static BirthDataSet ReadBitrhDataSet(string filePath)
        {
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                BirthDataSet result = new BirthDataSet();
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    Birth birth = new Birth();
                    switch(fields[1])
                    {
                        case "M": birth.Sex = Birth.Gender.Male;
                            break;
                        case "F": birth.Sex = Birth.Gender.Female;
                            break;
                        default:
                            break;
                    }
                    result.Births.Add(birth);
                }
                return result;
            }
        }
    }
}