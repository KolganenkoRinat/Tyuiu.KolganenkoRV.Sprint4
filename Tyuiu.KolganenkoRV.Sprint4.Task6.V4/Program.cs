using Tyuiu.KolganenkoRV.Sprint4.Task6.V4.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

var mas = new string[] { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };

Console.WriteLine("Исходный массив: ");
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(mas[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Результирующий массив: ");
string[] res = ds.Calculate(mas);

for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(res[i]);
}

Console.WriteLine();
Console.ReadKey();