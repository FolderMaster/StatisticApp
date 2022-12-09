namespace PrimaryStatisticProcessingApp.Models.Graphs
{
    public interface IShape
    {
        IShape Display(Graph schedule);

        double GetMax(Graph schedule, int axisIndex);

        double GetMin(Graph schedule, int axisIndex);
    }
}