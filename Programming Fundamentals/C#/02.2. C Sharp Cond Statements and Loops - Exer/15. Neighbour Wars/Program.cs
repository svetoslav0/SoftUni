using System;

namespace _15._Neighbour_Wars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var peshosAttack = int.Parse(Console.ReadLine());
            var goshosAttack = int.Parse(Console.ReadLine());
            int peshosHealth = 100;
            int goshosHealth = 100;
            int i = 0;
            while (peshosHealth > 0 || goshosHealth > 0)
            {
                i++;
                if (i % 2 == 1) //odd
                {
                    goshosHealth -= peshosAttack;
                    if (goshosHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                }
                else //even
                {
                    peshosHealth -= goshosAttack;
                    if (peshosHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                }
                if (peshosHealth <= 0 || goshosHealth <= 0)
                {
                    break;
                }
                else if (i % 3 == 0)
                {
                    peshosHealth += 10;
                    goshosHealth += 10;
                }
            }
            if (peshosHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {i}th round.");
            }
            else if (goshosHealth <= 0)
            {
                Console.WriteLine($"Pesho won in {i}th round.");
            }
        }
    }
}