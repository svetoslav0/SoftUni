using System;

namespace _07._Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            long current = 0;
            long id = 0;
            double years = 0;
            switch (dataType)
            {
                case "sbyte":
                    id = sbyte.MinValue;
                    break;
                case "int":
                    id = int.MinValue;
                    break;
                case "long":
                    id = long.MinValue;
                    break;
            }
            for (int i = 0; i < counter; i++)
            {

                current = long.Parse(Console.ReadLine());
                if (current >= sbyte.MinValue && current <= sbyte.MaxValue && current > id && dataType == "sbyte")
                {
                    id = current;
                }
                if (current >= int.MinValue && current <= int.MaxValue && current > id && dataType == "int")
                {
                    id = current;
                }
                if (current >= long.MinValue && current <= long.MaxValue && current > id && dataType == "long")
                {
                    id = current;
                }

            }
            if (id < 0)
            {
                years = Math.Ceiling((id / -128.0));
                PrintOutput(years, id);
            }
            else
            {
                years = Math.Ceiling((id / 127.0));
                PrintOutput(years, id);
            }
        }

        static void PrintOutput(double years, long id)
        {
            if (years > 1)
            {
                Console.WriteLine($"Prisoner with id {id} is sentenced to {years} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {id} is sentenced to {years} year");
            }
        }
    }
}