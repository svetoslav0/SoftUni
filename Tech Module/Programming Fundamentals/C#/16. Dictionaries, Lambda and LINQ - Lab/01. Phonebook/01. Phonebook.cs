using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var phonebook = new Dictionary<string,string>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if (input[0] == "END")
                {
                    break;
                }
                switch (input[0])
                {
                    case "A":
                        phonebook[input[1]] = input[2];
                        break;
                    case "S":
                        if (!phonebook.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"Contact {input[1]} does not exist.");
                        }
                        else
                        {
                            Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                        }
                        break;
                }
            }
        }
    }
}
