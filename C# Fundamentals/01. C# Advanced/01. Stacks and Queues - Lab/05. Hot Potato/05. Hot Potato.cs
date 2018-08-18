using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split().ToArray();
            int turns = int.Parse(Console.ReadLine());

            var queue = new Queue<string>();
            foreach (var person in people)
            {
                queue.Enqueue(person);
            }

            while (queue.Count > 1)
            {
                for (int i = 0; i < turns - 1; i++)
                {
                    string currentPerson = queue.Dequeue();
                    queue.Enqueue(currentPerson);
                }
                
                string currentRemoved = queue.Dequeue();
                Console.WriteLine($"Removed {currentRemoved}");
            }

            string lastPerson = queue.Dequeue();
            Console.WriteLine($"Last is {lastPerson}");
        }
    }
}
