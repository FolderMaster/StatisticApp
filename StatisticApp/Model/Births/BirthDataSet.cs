using System.Collections.Generic;

namespace StatisticApp.Model.Births
{
    public class BirthDataSet
    {
        public List<Birth> Births { get; set; } = new List<Birth>();

        public double SexRatio
        {
            get
            {
                double maleCount = 0;
                foreach (var birth in Births)
                {
                    if(birth.Sex == Birth.Gender.Male)
                    {
                        ++maleCount;
                    }
                }
                return maleCount / Births.Count;
            }
        }

        public int Count
        {
            get
            {
                return Births.Count;
            }
        }

        public BirthDataSet()
        {
        }

        public BirthDataSet(List<Birth> births)
        {
            Births = births;
        }
    }
}