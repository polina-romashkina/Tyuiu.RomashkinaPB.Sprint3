using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RomashkinaPB.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {

            int minCount = int.MaxValue;
            int currentCount = 0;
            foreach (char chr in value)
            { 
                if ( chr == item)
                {  
                    currentCount++; 
                }
                else
                {
                    if (currentCount > 0)
                    {
                        if (currentCount < minCount)
                        {
                            minCount = currentCount;
                        }
                    }
                    currentCount = 0;
                }
            
            }
            if (currentCount > 0 && currentCount < minCount)
            {
                minCount = currentCount;  
            }
            return minCount == int.MaxValue ? 0 : minCount;
        }
    }
}
