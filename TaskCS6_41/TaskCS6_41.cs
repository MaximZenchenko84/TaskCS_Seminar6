// Урок 6. Задача 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь

using System;

namespace TaskCS6_41
{
    class TaskCS6_41
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива, состоящего из вещественных чисел");
            int num_elements = int.Parse(Console.ReadLine());
            double[] array = new double[num_elements]; // объявление массива 
            Random rnd = new Random();
            int num_pol = 0; // счетчик чисел, больших нуля
            // цикл ввода элементов массива и подсчета количества элементов, бОльших нуля
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите " + i + "-й элемент массива ");
                array[i] = double.Parse(Console.ReadLine());
                num_pol = (array[i] > 0) ? (num_pol+1) : num_pol;
            }
            Console.WriteLine("Количество элементов, бОльших нуля, равно " + num_pol);
        }
    }
}
