using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($"Addition of numner is { AddTwoNumber(2, 3)}");
        }

        public static int AddTwoNumber(int a, int b)
        {
            return a + b;
        }
    }
}
