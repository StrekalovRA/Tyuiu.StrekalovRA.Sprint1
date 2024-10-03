using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.StrekalovRA.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            double Part_1 = (2 / Math.Tan(3 * x)); // 2ctg3x
            double Part_2 = Math.Log(Math.Cos(x), Math.E); // ln(cos(x))
            double Part_3 = Math.Log(1 + Math.Pow(x, 2), Math.E); // ln(1+x²)
            double Res_ = Part_1 - (Part_2 / Part_3);
            return Math.Round(Res_, 3);
        }
    }
}