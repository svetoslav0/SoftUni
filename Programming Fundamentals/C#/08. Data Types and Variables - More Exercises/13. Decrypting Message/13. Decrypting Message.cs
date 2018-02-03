using System;

namespace _13._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char currentChar;
            string result = "";
            for (int i = 0; i < n; i++)
            {
                currentChar = char.Parse(Console.ReadLine());
                currentChar += (char)key;
                result += currentChar;
            }
            Console.WriteLine(result);
        }
    }
}
