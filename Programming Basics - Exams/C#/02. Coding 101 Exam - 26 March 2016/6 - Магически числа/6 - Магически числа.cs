using System;

namespace _6___Магически_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int first = 1; first < 10; first++)
            {
                for(int second = 1; second < 10; second++)
                {
                    for(int third = 1; third < 10; third++)
                    {
                        for(int forth = 1; forth < 10; forth++)
                        {
                            for(int fifth = 1; fifth < 10; fifth++)
                            {
                                for(int sixth = 1; sixth < 10; sixth++)
                                {
                                    if (first * second * third * forth * fifth * sixth == number)
                                    {
                                        Console.Write($"{first}{second}{third}{forth}{fifth}{sixth} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
