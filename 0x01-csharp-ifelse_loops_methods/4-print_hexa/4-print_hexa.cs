using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 0; number <= 98; number++)
            {
                Console.WriteLine("{0} = 0x{1}", number, number.ToString("x"));
            }
        }
    }
}
