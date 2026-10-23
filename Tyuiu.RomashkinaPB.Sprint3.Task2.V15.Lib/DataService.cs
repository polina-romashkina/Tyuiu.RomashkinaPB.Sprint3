using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RomashkinaPB.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            do
            {
                SumSeries = SumSeries + ((Math.Pow(value, startValue) + (1.0 / 2)) * Math.Cos(startValue));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }
}
