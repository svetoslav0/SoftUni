using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _4.ConcatinateData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {name} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
