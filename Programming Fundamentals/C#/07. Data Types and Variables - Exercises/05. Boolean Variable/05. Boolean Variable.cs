using System;

namespace _05._Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifTrue = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(ifTrue);
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
