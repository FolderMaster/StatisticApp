using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StatisticApp.Model.Shedules
{
    public class Schedule
    {
        public List<Axis> Axises { get; set; } = new List<Axis>();

        public int Count
        {
            get
            {
                return Axises[0].Values.Count();
            }
        }
        
        public Schedule()
        {
        }

        public Schedule(IEnumerable<Axis> axises)
        {
            Axises = axises.ToList();
        }

        public IEnumerable<double> this[int index]
        {
            get
            {
                List<double> result = new List<double>();
                foreach(Axis axis in Axises)
                {
                    result.Add(axis.Displays[index]);
                }
                return result;
            }
        }
    }
}