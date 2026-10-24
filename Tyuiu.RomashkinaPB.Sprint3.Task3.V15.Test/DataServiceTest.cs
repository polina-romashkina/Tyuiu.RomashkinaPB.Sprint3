using Tyuiu.RomashkinaPB.Sprint3.Task3.V15.Lib;

namespace Tyuiu.RomashkinaPB.Sprint3.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();

            string str = "Irmmse mg sermmmrt";
            char chr = 'm';

            int res = ds.GetMinCharCount(str, chr);

            int wait = 1;

            Assert.AreEqual(wait, res);
        }
    }
}
