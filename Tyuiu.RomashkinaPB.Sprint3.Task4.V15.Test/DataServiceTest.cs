using Tyuiu.RomashkinaPB.Sprint3.Task4.V15.Lib;

namespace Tyuiu.RomashkinaPB.Sprint3.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 623.499;

            Assert.AreEqual(wait, res);
        }
    }
}
