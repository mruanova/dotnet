using System;

namespace calculator
{
    class Program
    {
        // delegate
        public delegate void Del(string message);
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        // Method With Callback
        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            int Sum = Calculator.Add(param1, param2);
            callback("The number is: " + Sum.ToString());
        }
        // Call this function by passing the params and actual delegate reference
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator!");
            // Instantiate the delegate to reference the DelegateMethod function
            Del handler = DelegateMethod;
            MethodWithCallback(1, 2, handler);
        }
    }
}
