using System;

namespace _5___Пеперуда
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the input number
            int n = int.Parse(Console.ReadLine());

            // Drawing the top part

            for (int i = 0; i < n - 2; i++)
            {
                char symbol;
                if (i % 2 == 0)
                {
                    symbol = '*';
                }
                else
                {
                    symbol = '-';
                }
                string wings = new string(symbol, n - 2);
                Console.WriteLine($@"{wings}\ /{wings}");
            }

            // Drawing the middle part
            Console.WriteLine($"{new string(' ', n - 1)}@");

            // Drawing the bottom part of the butterfly
            for (int i = 0; i < n - 2; i++)
            {
                char symbol;
                if (i % 2 == 0)
                {
                    symbol = '*';
                }
                else
                {
                    symbol = '-';
                }
                string wings = new string(symbol, n - 2);
                Console.WriteLine($@"{wings}/ \{wings}");
            }



        }
    }
}
