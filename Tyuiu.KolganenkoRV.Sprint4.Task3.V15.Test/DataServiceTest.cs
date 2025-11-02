using Tyuiu.KolganenkoRV.Sprint4.Task3.V15.Lib;

namespace Tyuiu.KolganenkoRV.Sprint4.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] numsArray = new int[5, 5] { { 2, 3, 4, 5, 6 }, { 8, 9, 2, 4, 6 }, { 8, 1, 3, 5, 7 }, { 9, 2, 3, 6, 7 }, { 9, 4, 5, 3, 6 } };
            int res = ds.Calculate(numsArray);
            int wait = 13;
            Assert.AreEqual(wait, res); 

        }
    }
}
