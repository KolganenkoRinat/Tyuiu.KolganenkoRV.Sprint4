using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KolganenkoRV.Sprint4.Task2.V19.Lib
{
    public class DataService : ISprint4Task2V19
    {
        public int Calculate(int[] array)
        {
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2 != 0) && (array[i] > 4) && (array[i] < 9))
                {
                    s += array[i];
                }
            }
            return s;
        }
    }
}
