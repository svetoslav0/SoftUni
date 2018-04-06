using System;
using System.Text.RegularExpressions;

namespace _03._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int counter = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'S' || input[j] == 's' || input[j] == 'T' || input[j] == 't' || input[j] == 'A' || input[j] == 'a' || input[j] == 'R' || input[j] == 'r')
                    {
                        counter++;
                    }
                }
                string decryptedMessage = "";
                for (int j = 0; j < input.Length; j++)
                {
                    decryptedMessage += (char)(input[j] - counter);
                }
                string[] parts = decryptedMessage.Split(new[] { '@', '-', '!', ':', '>' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(string.Join(", ", parts));

            }


        }
    }
}
