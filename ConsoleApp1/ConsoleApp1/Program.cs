using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 200; i++)
            {
                Console.Write($"{i} ");
                if(i%3 == 0)
                {
                    Console.Write("Fizz");
                }
                if(i%5 == 0)
                {
                    Console.Write("Buzz");
                }
                Console.WriteLine("");
            }
        }
    }
}
