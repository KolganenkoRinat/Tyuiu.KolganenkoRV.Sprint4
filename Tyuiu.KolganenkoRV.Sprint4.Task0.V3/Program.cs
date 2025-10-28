using Tyuiu.KolganenkoRV.Sprint4.Task0.V3.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #3 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] numsArray = {8, 9, 4, 1, 2, 3, 4, 5, 6, 7};
int p = 1;
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < numsArray.ToArray().Length; i++)
{
    Console.WriteLine(numsArray[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Результирующий массив: ");
p = ds.GetMultOddArrEl(numsArray);
Console.WriteLine("Произведение нечетных элементов массива: " + p);

Console.WriteLine();
Console.ReadKey();