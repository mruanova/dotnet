using System;
using System.Collections.Generic;
using System.Threading;

namespace Puzzles
{
    static class MyExtensions
    {
        public static class ThreadSafeRandom
        {
            [ThreadStatic] private static Random Local;

            public static Random ThisThreadsRandom
            {
                get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
            }
        }
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Puzzles!");
            /** Random Array */
            int[] arr1 = RandomArray();
            /** Coin Flip */
            Double ratio = TossMultipleCoins(25);
            Console.WriteLine(ratio);
            /** Names */
            Names();
        }
        /** Random Array */
        public static int[] RandomArray()
        {
            Console.WriteLine("Random Array");
            int[] values = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(5, 26); // 5 to 25 inclusive
                values[i] = num;
            }
            int min = values[0];
            int max = values[0];
            int sum = 0;
            foreach (int element in values)
            {
                if (element < min)
                {
                    min = element;
                }
                if (element > max)
                {
                    max = element;
                }
                sum += element;
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
            return values;
        }

        // TossCoin
        static string TossCoin()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 2); // 5 to 25 inclusive
            string coin = "";
            if (num == 0)
            {
                coin = "Heads";
            }
            else if (num == 1)
            {
                coin = "Tails";
            }
            else
            {
                coin = "Error";
            }
            Console.WriteLine("Tossing a Coin!" +  coin);
            return coin;
        }

        // TossMultipleCoins
        static Double TossMultipleCoins(int num)
        {
            int heads = 0;
            int tails = 0;
            Console.WriteLine("Toss Multiple Coins");
            for (int i = 0; i < num; i++)
            {
                string value = TossCoin();
                if (value == "Heads")
                {
                    heads++;
                }
                else if (value == "Tails")
                {
                    tails++;
                }
            }
            return heads / tails;
        }

        // Names
        static List<string> Names()
        {
            Console.WriteLine("Names");
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            names.Shuffle();
            foreach (string name in names)
            {
                if (name.Length > 5)
                {
                    Console.WriteLine(name);
                }
            }
            return names;
        }
    }
}
