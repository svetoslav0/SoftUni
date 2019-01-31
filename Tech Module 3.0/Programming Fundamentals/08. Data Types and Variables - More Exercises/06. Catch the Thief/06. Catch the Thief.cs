using System;

namespace _06._Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            long current = 0;
            long result = 0;
            switch (dataType)
            {
                case "sbyte":
                    result = sbyte.MinValue;
                    break;
                case "int":
                    result = int.MinValue;
                    break;
                case "long":
                    result = long.MinValue;
                    break;
            }
            for (int i = 0; i < counter; i++)
            {

                current = long.Parse(Console.ReadLine());
                if (current >= sbyte.MinValue && current <= sbyte.MaxValue && current > result && dataType == "sbyte")
                {
                    result = current;
                }
                if (current >= int.MinValue && current <= int.MaxValue && current > result && dataType == "int")
                {
                    result = current;
                }
                if (current >= long.MinValue && current <= long.MaxValue && current > result && dataType == "long")
                {
                    result = current;
                }

            }
            Console.WriteLine(result);

        }
    }
}
