using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Wedding_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            double guests = double.Parse(Console.ReadLine());
            double presents = double.Parse(Console.ReadLine());

            int catA = 0;
            int catB = 0;
            int catV = 0;
            int catG = 0;

            for (int i = 0; i < presents; i++)
            {
                switch (char.Parse(Console.ReadLine()))
                {
                    case 'A':
                        catA++;
                        break;
                    case 'B':
                        catB++;
                        break;
                    case 'V':
                        catV++;
                        break;
                    case 'G':
                        catG++;
                        break;
                }
            }

            Console.WriteLine($"{catA / presents * 100:f2}%");
            Console.WriteLine($"{catB / presents * 100:f2}%");
            Console.WriteLine($"{catV / presents * 100:f2}%");
            Console.WriteLine($"{catG / presents * 100:f2}%");
            Console.WriteLine($"{presents / guests * 100:f2}%");
        }
    }
}
