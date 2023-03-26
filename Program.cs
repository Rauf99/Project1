using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Homework2
    {
        public static void Main()
        {
            Console.Write("Введите размер массива:\t ");
            int elementsCount = 0;
            try
            {
                elementsCount = UInt16.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! Вы вели некорректное значение. ");
                return;
            }

            if (elementsCount < 2)
            {
                Console.WriteLine("Ошибка! Введите значение больше 1");
                return;
            }
            else
            {
                int[] array = new int[elementsCount];
                for (int i = 0; i < elementsCount; i++)
                {
                    Console.WriteLine($"Введите элемент массива под индексом {i}:\t");
                    try
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Ошибка! Некорректное значение индекса #{i}");
                        return;
                    }
                }
                int[] intArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    intArray[i] = Convert.ToInt32(array[i]);
                    int[] intArrayCopy = intArray.Distinct().ToArray();
                    Array.Sort(intArrayCopy);
                    Array.Reverse(intArrayCopy);
                    int checkArrayCopySize = intArrayCopy.Count();
                    if (checkArrayCopySize > 1)
                    {
                        Console.Write($"Второе наибольшее число в вашем массиве: {intArrayCopy[1]}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("\n\t\aОшибка! Невозможно вывести второе наибольшее число. В данном массиве только одно наибольшее число.");
                    }
                }
            }
        }
    }
}
