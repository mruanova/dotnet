using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("boxing unboxing!");
            //Box some string data into a variable
            object BoxedData = "This is clearly a string";
            //Make sure it is the type you need before proceeding
            if (BoxedData is int)
            {
                //This shouldn't run
                Console.WriteLine("I guess we have an integer value in this box?");
            }
            if (BoxedData is string)
            {
                Console.WriteLine("It is totally a string in the box!");
            }
            object ActuallyString = "a string";
            string ExplicitString = ActuallyString as string;

            // THIS WON'T WORK!!
            /*
            object ActuallyInt = 256;
            int ExplicitInt = ActuallyInt as int;
            */

            // Create an empty List of type object
            List<Object> parts = new List<Object>();
            // 7, 28, -1, true, "chair"
            parts.Add(7);
            parts.Add(28);
            parts.Add(-1);
            parts.Add(true);
            parts.Add("chair");
            // Loop through the list and print all values (Hint: Type Inference might help here!)  
            int sum = 0;
            parts.ForEach(element =>
            {
                Console.WriteLine(element);
                if (element is int)
                {
                    sum += (int)element;
                }
            });
            Console.WriteLine(sum);
        }
    }
}
