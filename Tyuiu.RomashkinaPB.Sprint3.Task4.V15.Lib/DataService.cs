using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RomashkinaPB.Sprint3.Task4.V15.Lib
{
    public class DataService : ISprint3Task4V15
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    res = res * (((Math.Sin(x) + x) / x) + 0.75);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
