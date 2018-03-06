using System;
using System.Collections.Generic;
using System.Linq;
namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int[] numbers = text
                .Split(' ')
                .Select(int.Parse)
                .ToArray();                                                     
            int[] numsInBigMass = new int[ushort.MaxValue + 1];                 
            int numbersLen = numbers.Length;                                    
            int maxIndex = 0;                                                   
            for (int i = 0; i < ushort.MaxValue; i++)                           
            {                                                                   
                for (int j = 0; j < numbersLen; j++)                                                                         
                {                                                           
                    if (numbers[j] == i)                                    
                    {                                                       
                        numsInBigMass[i]++;                                 
                    }                                                       
                }                                                           
            }                                                               
            int maxValue = 0;                                               
            for (int i = 0; i < numsInBigMass.Length; i++)                  
            {                                                               
                if (numsInBigMass[i] > maxValue)                            
                {                                                           
                    maxValue = numsInBigMass[i];                            
                }                                                           
            }                                                               
            List<int> mostFrequentNums = new List<int>();                   
            for (int i = 0; i < numsInBigMass.Length; i++)                  
            {                                                               
                if (numsInBigMass[i] == maxValue)                           
                {                                                           
                    mostFrequentNums.Add(i);                                
                }
            }
            int theMostFrNum = 0;
            bool found = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < mostFrequentNums.Count; j++)
                {
                    if (numbers[i] == mostFrequentNums[j])
                    {
                        theMostFrNum = numbers[i];
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            Console.WriteLine(theMostFrNum);
        }
    }
}
