using System;

namespace _1___Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double totalVegs = double.Parse(Console.ReadLine());
            double totalFruits = double.Parse(Console.ReadLine());
            double totalVegsPrice = vegPrice * totalVegs;
            double totalFruitPrice = fruitPrice * totalFruits;
            double totalPrice = (totalFruitPrice + totalVegsPrice) / 1.94;
            Console.WriteLine(totalPrice);
            
            
        }
    }
}
