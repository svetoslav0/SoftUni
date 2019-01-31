using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {                            //name              IPs      *days (not days -> duration)
            var logs = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[1];
                string ip = input[0];
                int days = int.Parse(input[2]);


                if (true)
                {

                }

            }
        }
    }
}
