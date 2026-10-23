using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RomashkinaPB.Sprint3.Task1.V15.Lib
{
    public class DataService : ISprint3Task1V15
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            while (startValue <= stopValue)
            {
                multiplySeries = multiplySeries * ((Math.Pow(value, 2) * startValue) + 1.0);
                startValue++;
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}
