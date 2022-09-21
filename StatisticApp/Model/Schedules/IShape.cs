using System.Collections.Generic;

namespace StatisticApp.Model.Schedules
{
    public interface IShape
    {
        IShape Display(Schedule schedule);

        double GetMax(Schedule schedule, int axisIndex);

        double GetMin(Schedule schedule, int axisIndex);
    }
}