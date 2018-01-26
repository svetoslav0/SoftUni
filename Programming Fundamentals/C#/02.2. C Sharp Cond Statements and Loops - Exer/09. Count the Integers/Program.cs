using System;

namespace _09._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = int.MinValue;
            try
            {
                while (n == int.MaxValue)
                {
                    n = int.Parse(Console.ReadLine());
                    i++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(i);
            }
        }
    }
}
