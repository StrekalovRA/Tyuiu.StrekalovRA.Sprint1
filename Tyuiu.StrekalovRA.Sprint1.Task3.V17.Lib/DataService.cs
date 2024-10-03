using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.StrekalovRA.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            int Digit_1 = (int)((number * 10) % 10);
            int Digit_2 = (int)((number * 100) % 10);
            int Digit_3 = (int)((number * 1000) % 10);

            if (Digit_1 == 0 || Digit_2 == 0 || Digit_3 == 0) { return true; }
            return false;
        }
    }
}