using System.Collections.Generic;

namespace StatisticApp.Model.Schedules
{
    public interface IShape
    {
        List<List<double>> Points { get; set; }

        IShape Display(Schedule schedule);
    }
}