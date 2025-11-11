using System.Data;
using Tyuiu.KolganenkoRV.Sprint4.Task7.V19.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int rows = 2;
int cols = 4;
int[,] mtrx = new int[rows, cols];
string str = "90817264";

Console.WriteLine("\nмассив: ");
int index = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine($"{str[index]} \t");
        index++;
    }
    Console.WriteLine();
}



Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(rows, cols, str);
Console.WriteLine("количество нечетных элементов: " + res);

Console.WriteLine();
Console.ReadKey();