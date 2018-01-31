using System;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = char.Parse(Console.ReadLine());
            if (input >= '0' && input <= '9')
            {
                Console.WriteLine("digit");
            }
            else if (input == 'a' || input == 'e' || input == 'u' || input == 'o' || input == 'y' || input == 'i')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
