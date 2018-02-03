using System;

namespace _04._Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputUnit = Console.ReadLine();
            double inputValue = double.Parse(Console.ReadLine());
            string outputUnit = "";
            double outputValue = 0.0;
            switch (inputUnit)
            {
                case "miles":
                    outputUnit = "kilometers";
                    outputValue = inputValue * 1.6;
                    break;
                case "inches":
                    outputUnit = "centimeters";
                    outputValue = inputValue * 2.54;
                    break;
                case "feet":
                    outputUnit = "centimeters";
                    outputValue = inputValue * 30;
                    break;
                case "yards":
                    outputUnit = "meters";
                    outputValue = inputValue * 0.91;
                    break;
                case "gallons":
                    outputUnit = "liters";
                    outputValue = inputValue * 3.8;
                    break;
            }
            Console.WriteLine($"{inputValue} {inputUnit} = {outputValue:f2} {outputUnit}");
        }
    }
}
