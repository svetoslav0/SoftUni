using System;
using System.Linq;
namespace _06._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] textMass = text
                .Split(' ')
                .ToArray();
            textMass = textMass.Reverse().ToArray();
            foreach (var item in textMass)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
