using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 0; number < 100; number++)
            {
                if (number < 99)
                {
                    Console.Write($"{number:00}, ");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
