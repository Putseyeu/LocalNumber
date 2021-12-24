using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localNumbersInTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            if (array[0] > array[1])
            {
                Console.WriteLine("Вывод локального числа " + array[0]);
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                //int j = i + 1;
                if (array[i] > array[i - 1])
                {
                    if (array[i] > array[i + 1])
                    {
                        Console.WriteLine("Вывод локального числа " + array[i]);
                    }
                }
            }            
            
            if (array[array.Length - 1] > array[array.Length - 2])
            {
                Console.WriteLine("Вывод локального числа " + array[array.Length - 1]);
            }               
        }
    }
}
