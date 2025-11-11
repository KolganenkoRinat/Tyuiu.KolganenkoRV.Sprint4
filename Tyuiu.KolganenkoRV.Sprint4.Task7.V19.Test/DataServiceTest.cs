using Tyuiu.KolganenkoRV.Sprint4.Task7.V19.Lib;

namespace Tyuiu.KolganenkoRV.Sprint4.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 2;
            int columns = 4;
            int[,] matrix = new int[rows, columns];
            string str = "90817264";
            int res = ds.Calculate(rows, columns, str);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
