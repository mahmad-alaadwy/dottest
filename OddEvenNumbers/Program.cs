using System;
using System.Collections.Generic;

namespace OddEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = { 1, 2, 3, 4 };

            Console.WriteLine("Hello World!");
            printNumbers("the number in the array are  ", numbs);
        }

        static void printNumbers(string title,IEnumerable<int> numbs)
        {
            Console.WriteLine();
            Console.Write($"{title}: [");
            foreach(var i in numbs)
            {
                Console.Write($"{i} ");
            }
            Console.Write($" ]");
            Console.WriteLine();
        }
    }
}
