using System;

namespace _06._Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the generated, the special and the control number from the console
            double m = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double specialNum = double.Parse(Console.ReadLine());
            double controlNum = double.Parse(Console.ReadLine());
            bool found = false;

            for (double i = m; i >= 1; i--)
            {
                for (double j = n; j >= 1; j--)
                {
                    for (double k = l; k >= 1; k--)
                    {
                        double generatedNum = 100 * i + 10 * j + k;
                        if (generatedNum % 3 == 0)
                        {
                            specialNum += 5;
                        }
                        else if (generatedNum % 10 == 5)
                        {
                            specialNum -= 2;
                        }
                        else if (generatedNum % 2 == 0)
                        {
                            specialNum *= 2;
                        }
                        
                        if (specialNum >= controlNum)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found)
                    {
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }


            if (found)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");
            }
            else
            {
                Console.WriteLine($"No! {specialNum} is the last reached special number.");
            }

        }
    }
}
