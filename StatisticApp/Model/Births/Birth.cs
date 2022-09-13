using System.IO;

namespace StatisticApp.Model.Births
{
    public class Birth
    {
        public Gender Sex { get; set; }

        public Birth()
        {
        }

        public Birth(string sex)
        {
            switch (sex)
            {
                case "M":
                    Sex = Gender.Male;
                    break;
                case "F":
                    Sex = Gender.Female;
                    break;
                default:
                    throw new InvalidDataException();
            }
        }

        public enum Gender
        {
            None,
            Male,
            Female
        }
    }
}