using System;

namespace _06._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumBorder = int.Parse(Console.ReadLine());
            int secondNumBorder = int.Parse(Console.ReadLine());
            int thirdNumBorder = int.Parse(Console.ReadLine());

            for (int i = 2; i <= firstNumBorder; i += 2)
            {
                for (int j = 2; j <= secondNumBorder;)
                {
                    for (int k = 2; k <= thirdNumBorder; k += 2)
                    {
                        Console.WriteLine($"{i} {j} {k}");
                    }
                    if (j == 2)
                    {
                        j++;
                    }
                    else if(j > 2 && j < 7)
                    {
                        j += 2;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            

        }
    }
}
