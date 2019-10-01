using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Take_or_Skip_Rope
{
    class Program
    {                                                                   // T2exs15ti23ng1_3cT1h3e0_Roppe
        static void Main(string[] args)                                 // TestingTheRope
        {
            string message = "T2exs15ti23ng1_3cT1h3e0_Roppe"; // Console.ReadLine();
            List<int> allNumbers = new List<int>();
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] >= '0' && message[i] <= '9')
                {
                    allNumbers.Add(int.Parse(message[i].ToString()));
                    message = message.Remove(i, 1);
                    i--;
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(allNumbers[i]);
                }
                else
                {
                    skipList.Add(allNumbers[i]);
                }
            }

            string result = string.Empty;

            for (int counter = 0; counter < takeList.Count; counter++)
            {
                int take = takeList[counter];
                int skip = skipList[counter];
                result += message.Substring(0, take % message.Length);
                message = message.Remove(0, (take + skip) % message.Length);
            }
            
            Console.WriteLine(result);


        }
    }
}
