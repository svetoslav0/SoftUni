using System;

namespace _14._Integer_to_Hex_and_Bin
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num,16).ToUpper());
            Console.WriteLine(Convert.ToString(num,2));
        }
    }
}
