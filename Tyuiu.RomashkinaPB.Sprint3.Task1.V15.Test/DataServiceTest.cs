using Tyuiu.RomashkinaPB.Sprint3.Task1.V15.Lib;

namespace Tyuiu.RomashkinaPB.Sprint3.Task1.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 2;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 208845;

            Assert.AreEqual(wait, res);
        }
    }
}
