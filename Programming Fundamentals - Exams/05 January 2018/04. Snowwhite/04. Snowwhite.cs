using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>(); 
            while (true)
            {
                string input = Console.ReadLine();
                string[] dwarf = input.Split(new char[] {' ', '<',':', '>'  }, StringSplitOptions.RemoveEmptyEntries);
                if (input == "Once upon a time")
                {
                    break;
                }
                Dwarf currentDwarf = new Dwarf
                {
                    Name = dwarf[0],
                    Color = dwarf[1],
                    Physics = int.Parse(dwarf[2])
                };
                if (dwarfs.Where(x => x.Name == currentDwarf.Name && x.Color == currentDwarf.Color && x.Physics < currentDwarf.Physics).Count() > 0)
                {
                    dwarfs.Where(x => x.Name == currentDwarf.Name).ToList().ForEach(b => b.Physics = currentDwarf.Physics);
                }
                else
                {
                    dwarfs.Add(currentDwarf);
                }

            }
            List<Dwarf> sortedList = dwarfs
                .OrderByDescending(o => o.Physics)                
                .ThenBy(o => o.Color)
                .ThenByDescending(o => o.Color.Count())
                .ToList();
            foreach (var item in sortedList)
            {
                Console.WriteLine($"({item.Color}) {item.Name} <-> {item.Physics}");
            }


        }
    }
}
