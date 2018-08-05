using System;

namespace _03._Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] arr = new long[n]; 
            arr[0] = 1;
            for (long i = 1; i < n; i++)
            {
                for (long j = i - k; j < i; j++)
                {
                    if (j >= 0)
                    {
                        arr[i] += arr[j];
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
