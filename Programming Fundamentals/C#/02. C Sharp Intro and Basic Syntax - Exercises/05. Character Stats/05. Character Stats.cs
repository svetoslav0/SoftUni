using System;

namespace _05._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var health = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var nrg = int.Parse(Console.ReadLine());
            var maxNrg = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|', health)}{new string('.', maxHealth - health)}|");
            Console.WriteLine($"Energy: |{new string('|', nrg)}{new string('.', maxNrg - nrg)}|");
        }
    }
}
