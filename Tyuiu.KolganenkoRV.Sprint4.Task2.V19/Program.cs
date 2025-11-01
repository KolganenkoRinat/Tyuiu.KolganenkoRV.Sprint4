using Tyuiu.KolganenkoRV.Sprint4.Task2.V19.Lib;

Random rnd = new Random();
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите кол-во элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] numsArray = new int[len];

for (int i = 0; i < len; i++)
{
    numsArray[i] = rnd.Next(4, 9);
}


Console.WriteLine("массив: ");

for (int i = 0; i < len; i++)
{
    Console.WriteLine(numsArray[i] + "\t");
}

Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(numsArray);
Console.WriteLine("Cумма нечетных элементов: " + res);

Console.WriteLine();
Console.ReadKey();