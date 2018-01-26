using System;

namespace _06._DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int count = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            char chekr;
            for (char i = 'A'; i <= 'T'; i++)
            {
                if (i == 'B' || (i > 'C' && i < 'G') || (i > 'G' && i < 'T'))
                {
                    continue;
                }
                for (char j = 'A'; j <= 'T'; j++)
                {
                    if (j == 'B' || (j > 'C' && j < 'G') || (j > 'G' && j < 'T'))
                    {
                        continue;
                    }
                    for (char k = 'A'; k <= 'T'; k++)
                    {
                        if (k == 'B' || (k > 'C' && k < 'G') || (k > 'G' && k < 'T'))
                        {
                            continue;
                        }
                        switch (i)
                        {
                            case 'A':
                                sum1 = 1;
                                break;
                            case 'C':
                                sum1 = 2;
                                break;
                            case 'G':
                                sum1 = 3;
                                break;
                            case 'T':
                                sum1 = 4;
                                break;
                        }
                        switch (j)
                        {
                            case 'A':
                                sum2 = 1;
                                break;
                            case 'C':
                                sum2 = 2;
                                break;
                            case 'G':
                                sum2 = 3;
                                break;
                            case 'T':
                                sum2 = 4;
                                break;
                        }
                        switch (k)
                        {
                            case 'A':
                                sum3 = 1;
                                break;
                            case 'C':
                                sum3 = 2;
                                break;
                            case 'G':
                                sum3 = 3;
                                break;
                            case 'T':
                                sum3 = 4;
                                break;
                        }
                        int sum = sum1 + sum2 + sum3;
                        if (sum >= n)
                        {
                            chekr = 'O';
                        }
                        else
                        {
                            chekr = 'X';
                        }
                        Console.Write($"{chekr}{i}{j}{k}{chekr} ");
                        count++;
                        if (count % 4 ==0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
