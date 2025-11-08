using Tyuiu.KolganenkoRV.Sprint4.Task4.V22.Lib;
3
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #22                                                             *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите кол-во сторк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, cols];
Console.WriteLine("***************************************************************************");
Console.WriteLine("массив: ");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine($"Введите значение {i},{j} элемент массива: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}




Console.WriteLine("\nмассив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}



Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("\nмассив: ");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.ReadKey();