using System;
using System.Linq;
namespace _02._Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            numbers = numbers.Reverse().ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, numbers));
        }
    }
}
