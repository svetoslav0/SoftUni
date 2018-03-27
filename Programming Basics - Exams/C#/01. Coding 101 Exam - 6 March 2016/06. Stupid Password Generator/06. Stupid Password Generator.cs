using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (char k = 'a'; k < l + 97; k++)
                    {
                        for (char m = 'a'; m < l + 97; m++)
                        {
                            for (int o = 1; o <= n; o++)
                            {
                                if (o > i && o > j)
                                {
                                    Console.Write($"{i}{j}{k}{m}{o} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
