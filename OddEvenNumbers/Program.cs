using System;
using System.Collections.Generic;
using System.Linq;

namespace OddEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = { 1, 2, 3, 4 };

            Console.WriteLine("Hello World!");
            printNumbers("the number in the array are  ", numbs);

            printNumbers("odd numbers ", numbs.Where(x => IsOdd(x)));

            printNumbers("even numbers ", numbs.Where(x => IsEven(x)));


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


        static bool IsEven(int number) => number % 2 == 0;

        static bool IsOdd(int number) => !IsEven(number) ;
    }
}
