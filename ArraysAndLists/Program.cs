using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i+1;
            }
            
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();
            Console.WriteLine(numbers[0]%2);

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i]%2 == 0)
                {
                    evens.Add(numbers[i]);
                }
                else
                {
                    odds.Add(numbers[i]);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Here is a list of even numbers:");
            foreach (var num in evens)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("And now...");
            Console.WriteLine("Here is a list of odd numbers:");
            foreach (int odd in odds)
            {
                Console.WriteLine(odd);
            }
        }
    }
}
