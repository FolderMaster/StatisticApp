namespace StatisticApp.Model.Births
{
    public class Birth
    {
        public Gender Sex { get; set; }

        public Birth()
        {
        }

        public Birth(Gender sex)
        {
            Sex = sex;
        }

        public enum Gender
        {
            None,
            Male,
            Female
        }
    }
}