using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();
            CultureInfo provider = CultureInfo.InvariantCulture;
            string format = "dd-MM-yyyy";
            DateTime inDate = DateTime.ParseExact(inputDate, format, provider);
            Console.WriteLine($"{(inDate.AddDays(999)):dd-MM-yyyy}");
        }
    }
}
