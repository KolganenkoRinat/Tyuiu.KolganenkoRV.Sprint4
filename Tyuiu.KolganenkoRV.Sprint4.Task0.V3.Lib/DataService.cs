using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KolganenkoRV.Sprint4.Task0.V3.Lib
{
    public class DataService : ISprint4Task0V3
    {
        public int GetMultOddArrEl(int[] Array)
        {
            int p = 1; 
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 != 0)
                { 
                    p = p * Array[i];
                }
            
            }
            return p;
        }
    }
}
