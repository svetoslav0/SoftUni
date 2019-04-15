using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSectorCh = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = 'A'; i <= lastSectorCh; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    int currentSeats = (j % 2 == 0) ? seats + 2 : seats;
                    for (char k = 'a'; k < 'a' + currentSeats; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                        counter++;
                    }
                }
                rows++;
            }

            Console.WriteLine(counter);

        }
    }
}
