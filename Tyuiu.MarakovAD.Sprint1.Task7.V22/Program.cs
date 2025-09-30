﻿using Tyuiu.MarakovAD.Sprint1.Task7.V22.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Мараков А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #22                                                              *");
        Console.WriteLine("* Выполнил: Мараков Андрей Дмитриевич | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
        Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*              ctgx                                                       *");
        Console.WriteLine("* z = (1 - tnx)     + cos(x - y)                                          *");
        Console.WriteLine("*                                                                         *");
        double x,y;
        Console.WriteLine("Введите значение x: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(x,y));
        Console.ReadKey();
    }
}