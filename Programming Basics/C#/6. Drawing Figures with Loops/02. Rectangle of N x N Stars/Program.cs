﻿using System;

namespace _02._Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*',n));
            }
        }
    }
}
