using Tyuiu.KolganenkoRV.Sprint4.Task1.V4.Lib;

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
int len;
Console.WriteLine("Введите кол-во элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());
int p = 1;
int[] numsArray = new int[len];
for (int i = 0; i < len; i++)
{
    Console.WriteLine("Введите значение " + i + " элемента массива: ");
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("массив: ");

for (int i = 0; i < len; i++)
{
    Console.WriteLine(numsArray[i] + "\t");
}

Console.WriteLine();

Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(numsArray);
Console.WriteLine("Произведение нечетных элементов массива: " + res);

Console.WriteLine();
Console.ReadKey();