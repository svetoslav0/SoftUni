using System;

namespace _08.__SMS_Typing
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int num = 0;
            string message = "";
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                char result = Convert.ToChar(((num % 10 - 2) * 3) + num.ToString().Length + 96);
                if (num%10 >= 8)
                {
                    result++;
                }
                if (num == 0)
                {
                    result = ' ';
                }
                message += result.ToString();
            }
            Console.WriteLine(message);
        }
    }
}