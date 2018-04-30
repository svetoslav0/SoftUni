using System;
using System.Collections.Generic;

namespace _02._PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
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
                else if (contact[0] == "ListAll")
                {
                    foreach (var kvp in phonebook)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }

            }
        }
    }
}
