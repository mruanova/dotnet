using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic 13!");
            // 1 Print 1-255
            PrintNumbers();
            // 2 Print odd numbers between 1-255
            PrintOdds();
            // 3 Print Sum
            PrintSum();
            // 4 Iterating through an Array
            int[] numArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            LoopArray(numArray);
            // 5 Find Max
            int[] numArray1 = new int[] { 10, 1, 2, 3, 4, 15, 6, 7, 8, 9 };
            int max1 = FindMax(numArray1);
            Console.WriteLine(max1); // 15
            int[] numArray2 = new int[] { -3, -5, -7 };
            int max2 = FindMax(numArray2);
            Console.WriteLine(max2); // -3
            int[] numArray3 = new int[] { 0, 1, 2, 3, -5, -7, 7, 8, 9 };
            int max3 = FindMax(numArray3);
            Console.WriteLine(max3); // 9
            // 6 Get Average
            int[] numArray6 = new int[] { 2, 10, 3 };
            GetAverage(numArray6); // 5
            // 7 Array with Odd Numbers
            int[] numArray7 = OddArray();
            foreach (int num in numArray7)
            {
                Console.WriteLine(num);
            }
            // 8 Greater than Y
            int y = 3;
            int[] numbers = new int[] { 1, 3, 5, 7 };
            int value8 = GreaterThanY(numbers, y);
            Console.WriteLine(value8);
            // 9 Square the Values
            int[] numbers9 = new int[] { 1, 5, 10, -10 };
            SquareArrayValues(numbers9);
            // 10 Eliminate Negative Numbers
            int[] numbers10 = new int[] { 1, 5, 10, -2 };
            EliminateNegatives(numbers10);
            // 11 Min, Max, and Average
            int[] numbers11 = new int[] { 1, 5, 10, -2 };
            MinMaxAverage(numbers11);
            // 12 Shifting the values in an array
            int[] numbers12 = new int[] { 1, 5, 10, 7, -2 };
            ShiftValues(numbers12); // 5, 10, 7, -2, 0
            // 13 Number to String
            int[] numbers13 = new int[] { -1, -3, 2 };
            NumToString(numbers13); // ['Dojo', 'Dojo', 2]
        }
        /** Print 1-255 */
        public static void PrintNumbers()
        {
            Console.WriteLine("Print all of the integers from 1 to 255.");
            for (int idx = 1; idx <= 255; idx++)
            {
                Console.WriteLine(idx);
            }
        }
        /** Print odd numbers between 1-255 */
        public static void PrintOdds()
        {
            Console.WriteLine("Print all of the odd integers from 1 to 255.");
            for (int idx = 1; idx <= 255; idx++)
            {
                if (idx % 2 != 0)
                {
                    Console.WriteLine(idx);
                }
            }
        }
        /** Print Sum */
        public static void PrintSum()
        {
            Console.WriteLine("Print Sum");
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            int sum = 0;
            for (int idx = 0; idx <= 255; idx++)
            {
                sum += idx;
                Console.WriteLine("New number: " + idx + " Sum: " + sum);
            }
        }
        /** Iterating through an Array */
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            Console.WriteLine("Iterating through an Array");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        /** Find Max */
        public static int FindMax(int[] numbers)
        {
            Console.WriteLine("Find Max");
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
        /** Get Average */
        public static void GetAverage(int[] numbers)
        {
            Console.WriteLine("Get Average");
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            decimal avg = sum / numbers.Length;
            Console.WriteLine(avg);
        }
        /** Array with Odd Numbers */
        public static int[] OddArray()
        {
            Console.WriteLine("Array with Odd Numbers");
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            List<int> numbers = new List<int>();
            for (int idx = 0; idx <= 255; idx++)
            {
                if (idx % 2 != 0)
                {
                    numbers.Add(idx);
                }
            }
            int[] numArray = new int[numbers.Count];
            for (int idx = 0; idx < numArray.Length; idx++)
            {
                numArray[idx] = numbers[idx];
            }
            return numArray;
        }
        /** Greater than Y */
        public static int GreaterThanY(int[] numbers, int y)
        {
            Console.WriteLine("Greater than Y");
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            foreach (int number in numbers)
            {
                if (number > y)
                {
                    count++;
                }
            }
            return count;
        }
        /** Square the Values */
        public static void SquareArrayValues(int[] numbers)
        {
            Console.WriteLine("Square the Values");
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                numbers[idx] = numbers[idx] * numbers[idx];
                Console.WriteLine(numbers[idx]);
            }
        }
        /** Eliminate Negative Numbers */
        public static void EliminateNegatives(int[] numbers)
        {
            Console.WriteLine("Eliminate Negative Numbers");
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                if (numbers[idx] < 0)
                {
                    numbers[idx] = 0;
                }
                Console.WriteLine(numbers[idx]);
            }
        }
        /** Min, Max, and Average */
        public static void MinMaxAverage(int[] numbers)
        {
            Console.WriteLine("Min, Max, and Average");
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                if (numbers[idx] > max)
                {
                    max = numbers[idx];
                }
                if (numbers[idx] < min)
                {
                    min = numbers[idx];
                }
                sum += numbers[idx];
            }
            decimal avg = sum / numbers.Length;
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(avg);
        }
        /** Shifting the values in an array */
        public static void ShiftValues(int[] numbers)
        {
            Console.WriteLine("Shifting the values in an array");
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for (int idx = 0; idx < numbers.Length - 1; idx++)
            {
                numbers[idx] = numbers[idx + 1];
                Console.WriteLine(numbers[idx]);
            }
            numbers[numbers.Length - 1] = 0;
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
        /** Number to String */
        public static object[] NumToString(int[] numbers)
        {
            Console.WriteLine("Number to String");
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] values = new object[numbers.Length];
            for (int idx = 0; idx < numbers.Length; idx++)
            {
                if (numbers[idx] >= 0)
                {
                    values[idx] = numbers[idx];
                    Console.WriteLine(values[idx]);
                }
                else
                {
                    values[idx] = "Dojo";
                    Console.WriteLine(values[idx]);
                }
            }
            return values;
        }
    }
}
