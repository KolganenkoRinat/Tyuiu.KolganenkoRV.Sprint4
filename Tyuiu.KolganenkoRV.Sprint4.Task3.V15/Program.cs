using Tyuiu.KolganenkoRV.Sprint4.Task3.V15.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] mtrx = new int[5, 5] { { 7, 4, 2, 5, 3 }, { 4, 3, 2, 5, 6 }, { 6, 3, 4, 7, 5 }, { 5, 7, 4, 3, 8 }, { 7, 8, 8, 5, 6 } };
int rows = 5;
int cols = 5;

Console.WriteLine("массив: ");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();
}



Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(mtrx);
Console.WriteLine("количество нечетных элементов: " + res);

Console.WriteLine();
Console.ReadKey();