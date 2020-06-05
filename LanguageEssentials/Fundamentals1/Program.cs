using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fundamentals 1");

            // Create a Loop that prints all values from 1-255 
            loopPrint(1, 255);

            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both 
            loopDivisible();

            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5 
            fizzBuzz();

            // (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!

            // EXTRA: Generate a sequence of integers from 1 to 10 and then select their squares.
            loopSquares();
        }

        // Create a Loop that prints all values from 1-255 
        static void loopPrint(int from, int to)
        {
            Console.WriteLine("Create a Loop that prints all values from 1-255.");
            for (int i = from; i <= to; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both 
        static void loopDivisible()
        {
            Console.WriteLine("Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both.");
            for (int i = 1; i <= 100; i++)
            {
                bool divBy3 = i % 3 == 0;
                bool divBy5 = i % 5 == 0;
                if (divBy3 || divBy5)
                {
                    bool divBy3and5 = divBy3 && divBy5;
                    if (!divBy3and5)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5 
        static void fizzBuzz()
        {
            Console.WriteLine("Modify the previous loop to print Fizz for multiples of 3, Buzz for multiples of 5, and FizzBuzz for numbers that are multiples of both 3 and 5.");
            for (int i = 1; i <= 100; i++)
            {
                bool divBy3 = i % 3 == 0;
                bool divBy5 = i % 5 == 0;
                if (divBy3 || divBy5)
                {
                    bool divBy3and5 = divBy3 && divBy5;
                    if (!divBy3and5)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        // (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!

        // Generate a sequence of integers from 1 to 10 and then select their squares.
        static void loopSquares()
        {
            Console.WriteLine("Generate a sequence of integers from 1 to 10 and then select their squares.");
            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);
            foreach (int num in squares)
            {
                Console.WriteLine(num);
            }
            /*
             This code produces the following output:
             1
             4
             9
             16
             25
             36
             49
             64
             81
             100
            */
        }
    }
}
