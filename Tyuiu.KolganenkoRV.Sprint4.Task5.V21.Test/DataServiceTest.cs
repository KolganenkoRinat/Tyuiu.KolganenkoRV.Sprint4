using Tyuiu.KolganenkoRV.Sprint4.Task5.V21.Lib;

namespace Tyuiu.KolganenkoRV.Sprint4.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 4, 3, 2, 4, 5 },{ 5, 4, 5, 6, 6 },{ 6, 2, 3, 6, 5 },{ 6, 2, 3, 6, 4 },{ 6, 2, 6, 6, 2 } };
            int[,] wait = new int[5,5] { { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 } };
            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
