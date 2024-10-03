using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.StrekalovRA.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            sbyte Symbs = 0;
            foreach (char s in value) { if (s == '!') { Symbs+=1; break; } }
            foreach (char s in value) { if (s == '?') { Symbs += 1; break; } }

            if (Symbs ==2 ) { return true; }
            return false;
        }
    }
}