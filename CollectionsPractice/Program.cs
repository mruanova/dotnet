using System;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            threeBasicArrays();
        }
        static void threeBasicArrays()
        {
            // Create an array to hold integer values 0 through 9
            int[] numArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int num in numArray)
            {
                Console.WriteLine(num);
            }
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            // Create an array of length 10 that alternates between true and false values, starting with true
            Boolean[] alternates = new Boolean[10];
            for (int idx = 0; idx < alternates.Length; idx++)
            {
                if (idx % 2 == 0)
                {
                    alternates[idx] = true;
                }
                Console.WriteLine(alternates[idx]);
            }
            Console.WriteLine("Three Basic Arrays");
        }
    }
}
