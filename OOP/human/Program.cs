using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Human");
            Human mau = new Human("mau");
            Human otro = new Human("mau",2,2,2,20);
            int value = mau.Attack(otro);
            Console.WriteLine(value);
        }
    }
}
