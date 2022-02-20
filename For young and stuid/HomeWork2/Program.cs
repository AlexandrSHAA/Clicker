using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static int[,] CreateRandom2Array(uint height, uint widght)
        {
            int[,] array = new int[height, widght];
            Random random = new Random(10);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    array[i, j] = random.Next(10);

                    Console.Write(array[i, j] + "\t");


                }
                Console.WriteLine();
            }
            return array;
        }
        static int searchingIndex(int [,] arr, int target)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int value = arr[i, j];
                    if (value == target) 
                    {
                        Console.WriteLine("Y " + (i + 1) + "X " + (j + 1));
                        return arr[i, j];
                    }
                    
                }                
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту массива");
            uint height = UInt32.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину массива");
            uint widght = UInt32.Parse(Console.ReadLine());

            int [,] array = CreateRandom2Array(height, widght);


            Console.WriteLine("Какое чисо найти?");

            int target = Int32.Parse(Console.ReadLine());

            searchingIndex(array, target);

            if(searchingIndex(array, target) == -1)
            {
                Console.WriteLine("Данного числа нет в массиве!");
            }



        }
    }
}
