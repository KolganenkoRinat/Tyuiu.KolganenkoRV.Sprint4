using System.Data;
using Tyuiu.KolganenkoRV.Sprint4.Task5.V21.Lib;
Random rnd = new Random();
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите кол-во строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во колонок массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] numsArray = new int [rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        numsArray[i,j] = rnd.Next(-8, 2);

    }
}


Console.WriteLine("массив: ");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine(numsArray[i, j] + "\t");
    }
}

Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int[,] res = ds.Calculate(numsArray);

Console.WriteLine(" Результирующий массив: ");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine(res[i, j] + "\t");
    }
}

Console.WriteLine();
Console.ReadKey();