using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forcebook = new Dictionary<string, List<string>>();
            List<string> input = Console.ReadLine().Split().ToList();
            while(input[0] != "Lumpawaroo")
            {
                string delimiter = "";
                string leftSide = "";
                string rightSide = "";

                if (input.Contains("|"))
                {
                    delimiter = "|";
                    long delimiterIndex = input.IndexOf("|");
                    for (long i = 0; i < delimiterIndex; i++)
                    {
                        leftSide += $"{input[(int)i]} ";
                    }
                    for (long i = delimiterIndex + 1; i < input.Count; i++)
                    {
                        rightSide += $"{input[(int)i]} ";
                    }


                    leftSide = leftSide.Trim();
                    rightSide = rightSide.Trim();
                }
                else if (input.Contains("->"))
                {
                    delimiter = "->";
                    long delimiterIndex = input.IndexOf("->");
                    for (long i = 0; i < delimiterIndex; i++)
                    {
                        leftSide += $"{input[(int)i]} ";
                    }
                    for (long i = delimiterIndex + 1; i < input.Count; i++)
                    {
                        rightSide += $"{input[(int)i]} ";
                    }


                    leftSide = leftSide.Trim();
                    rightSide = rightSide.Trim();

                }

                if (delimiter == "|")
                {
                    var forceSide = leftSide;
                    var forceUser = rightSide;
                    if (!forcebook.ContainsKey(forceSide))
                    {
                        List<string> currentList = new List<string>();
                        currentList.Add(forceUser);
                        forcebook.Add(forceSide, currentList);
                    }
                    else if(!forcebook[forceSide].Contains(forceUser))
                    {
                        forcebook[forceSide].Add(forceUser);
                    }
                }
                else if (delimiter == "->")     // User1 -> forceSide12
                {
                    var forceUser = leftSide;
                    var forceSide = rightSide;

                    bool userFound = false;
                    string searchedSide = "";
                    foreach (var side in forcebook.Keys)
                    {
                        if (forcebook[side].Contains(forceUser))
                        {
                            userFound = true;
                            searchedSide = side;
                        }

                        if (userFound)
                        {
                            long index = forcebook[searchedSide].IndexOf(forceUser);
                            forcebook[searchedSide].RemoveAt((int)index);
                            break;
                        }
                    }

                    if (!forcebook.ContainsKey(forceSide))
                    {
                        List<string> helper = new List<string>();
                        forcebook.Add(forceSide, helper);
                    }

                    forcebook[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }



                input = Console.ReadLine().Split().ToList();
            }

            foreach (var item in forcebook.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                if (item.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count()}");
                }
                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }


        }
    }
}
