using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RomashkinaPB.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 0;
            int i;
            for ( i =startValue; i <= stopValue; i++)
            {
                multiplySeries = multiplySeries + (Math.Pow(value, i) + 1.0 / (i + 1));
            }
            return Math.Round(multiplySeries,3);
        }
    }
}
