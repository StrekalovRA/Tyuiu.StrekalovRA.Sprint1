using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.StrekalovRA.Sprint1.Task4.V17.Lib
{
    public class DataService : ISprint1Task4V17
    {
        public double Calculate(double x, double y)
        {
            double T = 1 / (Math.Sqrt(x - 5 * y));
            return Math.Round(T, 3);
        }
    }
}