using System;

namespace _03._Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double result = 0.0;
            string oddOrEven = "even";

            switch (action)
            {
                case "+":
                    result = num1 + num2;
                    if (result % 2 != 0)
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine($"{num1} + {num2} = {result} - {oddOrEven}");
                    break;
                case "-":
                    result = num1 - num2;
                    if (result % 2 != 0)
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine($"{num1} - {num2} = {result} - {oddOrEven}");
                    break;
                case "*":
                    result = num1 * num2;
                    if (result % 2 != 0)
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine($"{num1} * {num2} = {result} - {oddOrEven}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2:f2}");
                    }
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    }
                    break;

            }
        }
    }
}
