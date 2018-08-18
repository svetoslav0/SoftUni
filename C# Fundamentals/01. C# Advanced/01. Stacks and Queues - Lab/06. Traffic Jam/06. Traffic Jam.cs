using System;
using System.Collections.Generic;

namespace _06._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPerLoop = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int counter = 0;

            string input = "";
            while (input != "end")
            {
                input = Console.ReadLine();
                if (input == "green")
                {
                    for (int i = 0; i < carsPerLoop; i++)
                    {
                        if (queue.Count > 0)
                        {
                            string passedCar = queue.Dequeue();
                            Console.WriteLine($"{passedCar} passed!");
                            counter++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
