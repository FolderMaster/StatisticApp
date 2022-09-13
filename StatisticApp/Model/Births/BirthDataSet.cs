using System.Collections.Generic;
using System.Linq;

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
                foreach (Birth birth in Births)
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

        public BirthDataSet(IEnumerable<Birth> births)
        {
            Births = births.ToList();
        }

        public static double GetGeneralSexRatio(IEnumerable<BirthDataSet> birthDataSets)
        {
            double maleCount = 0;
            double count = 0;
            foreach(BirthDataSet birthDataSet in birthDataSets)
            {
                foreach (var birth in birthDataSet.Births)
                {
                    if (birth.Sex == Birth.Gender.Male)
                    {
                        ++maleCount;
                    }
                }
                count += birthDataSet.Count;
            }
            return maleCount / count;
        }
    }
}