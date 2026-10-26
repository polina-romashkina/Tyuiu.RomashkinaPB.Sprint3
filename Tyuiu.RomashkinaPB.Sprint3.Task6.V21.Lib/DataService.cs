using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RomashkinaPB.Sprint3.Task6.V21.Lib
{
    public class DataService : ISprint3Task6V21
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    if (x % y == 0)
                    {
                        sum += y;
                    }
                }
            }
            return sum;
        }
    }
}
