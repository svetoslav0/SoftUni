using System;

namespace _05._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string language = Console.ReadLine().ToLower();
            switch (language)
            {
                case "usa":
                case "england":
                    Console.WriteLine("English");
                    break;
                case "spain":
                case "mexico":
                case "argentina":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
