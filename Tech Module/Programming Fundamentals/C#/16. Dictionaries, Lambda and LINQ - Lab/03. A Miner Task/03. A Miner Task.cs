using System;
using System.Linq;
using System.Collections.Generic;
namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            while (true)
            {
                string resourse = Console.ReadLine();
                if (resourse == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(resourse))
                {
                    dict[resourse] = quantity;
                }
                else
                {
                    dict[resourse] += quantity;

                }

            }
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
