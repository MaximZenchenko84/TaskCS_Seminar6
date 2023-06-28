//  Урок 6. Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1*x+b1, y = k2*x+b2;
// значения b1, k1, b2 и k2 задаются пользователем

using System;

namespace TaskCS6_43
{
    class TaskCS_43
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент наклона первой прямой k1 = ");
            double k1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите свободное слагаемое первой прямой b1 = ");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент наклона второй прямой k2 = ");
            double k2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите свободное слагаемое второй прямой b2 = ");
            double b2 = double.Parse(Console.ReadLine());
            if (k1 == k2)
            {
                if (b1 == b2)
                {
                    Console.WriteLine("Прямые совпадают");
                    return;
                }
                else
                {
                    Console.WriteLine("Прямые параллельны, точек пересечения нет");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Координаты точки пересечения (" + ((b2 - b1) / (k1 - k2)) + "; " + (k1 * (b2 - b1) / (k1 - k2) + b1) + ")");              
            }

        }
    }
}
