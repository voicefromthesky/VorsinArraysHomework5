using System;

namespace VorsinArraysHomework5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Array.Sort(array);
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();

            //Homework 6

            Console.WriteLine(Array.IndexOf(array, 5) );

            //Homework 7
            
            int[] array2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Array.Sort(array2);
            int index = Array.IndexOf(array2, 5);
            array2[index] = 88;

            //Скорее всего я не до конца понял как правильно сделать задачи. НО! Я зделять.

        }

    }
}
