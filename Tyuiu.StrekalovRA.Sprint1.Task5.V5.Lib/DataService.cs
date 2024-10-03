using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.StrekalovRA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            int K = Convert.ToInt16((x * 10) % 10);
            return K;
        }
    }
}