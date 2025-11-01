using Tyuiu.KolganenkoRV.Sprint4.Task2.V19.Lib;

namespace Tyuiu.KolganenkoRV.Sprint4.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 21, 32, 123 };
            int res = ds.Calculate(numsArray);
            int wait = 180;
            Assert.AreEqual(wait, res);

        }
    }
}
