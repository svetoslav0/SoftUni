using System;

namespace _06._Цифри
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a three-digit number from the console
            int n = int.Parse(Console.ReadLine());

            // Save the important data
            int printedNumbers = 0;
            int firstDigit = n / 100;
            int secondDigit = n / 10 % 10;
            int thirdDigit = n % 10;
            int rows = firstDigit + secondDigit;
            int columns = firstDigit + thirdDigit;

            // Loop until all numbers are printed
            while (printedNumbers < columns * rows)
            {
                // Change the input number on specific conditions
                if (n % 5 == 0)
                {
                    n -= firstDigit;
                }
                else if (n % 3 == 0)
                {
                    n -= secondDigit;
                }
                else
                {
                    n += thirdDigit;
                }

                // Print the current number
                Console.Write($"{n} ");
                printedNumbers++;
                if (printedNumbers % columns == 0)
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
