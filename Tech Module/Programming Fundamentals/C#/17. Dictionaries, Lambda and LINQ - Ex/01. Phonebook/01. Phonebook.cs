using System;
using System.Collections.Generic;

namespace _01._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] contact = input.Split();
                if (contact[0] == "A")
                {
                    var name = contact[1];
                    var phone = contact[2];
                    phonebook[name] = phone;

                }
                else if (contact[0] == "S")
                {
                    var name = contact[1];
                    if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                }

            }
        }
    }
}
