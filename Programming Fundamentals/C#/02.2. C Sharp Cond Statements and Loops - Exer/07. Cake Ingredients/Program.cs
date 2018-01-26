using System;

namespace _07._Cake_Ingredients
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int n = 0;
            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
                n++;
            }
            Console.WriteLine($"Preparing cake with {n} ingredients.");
        }
    }
}