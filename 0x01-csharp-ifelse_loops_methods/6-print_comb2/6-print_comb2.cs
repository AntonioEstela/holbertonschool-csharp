using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int first = 0; first <= 9; first++)
            {
                for (int second = 1; second <= 9; second++)
                {
                    if (second > first)
                    {
                        Console.Write($"{first}{second}");
                        if (first < 8)
                        {
                            Console.Write(", ");
                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                    }
                }
            }
        }
    }
}
