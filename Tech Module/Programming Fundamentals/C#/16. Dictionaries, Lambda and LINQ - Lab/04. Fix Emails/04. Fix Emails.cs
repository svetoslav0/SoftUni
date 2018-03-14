using System;
using System.Linq;
using System.Collections.Generic;
namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();
                char[] domainArr = email.Reverse().Take(2).Reverse().ToArray();
                string domain = "";
                for (int i = 0; i < domainArr.Length; i++)
                {
                    domain += domainArr[i];
                }
                if (domain != "uk" && domain != "us")
                {
                    emails[name] = email;
                }
            }
            foreach (var kvp in emails)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
