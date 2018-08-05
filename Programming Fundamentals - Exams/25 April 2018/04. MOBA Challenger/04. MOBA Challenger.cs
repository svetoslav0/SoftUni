using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Season end")
            {
                string[] currentInput = input.Split().ToArray();
                if (currentInput.Length == 5)
                {
                    string player = currentInput[0];
                    string position = currentInput[2];
                    int skill = int.Parse(currentInput[4]);
                    var helperDict = new Dictionary<string, int>();
                    helperDict.Add(position, skill);


                    if (!book.ContainsKey(player))
                    {
                        book.Add(player, helperDict);
                    }
                    else 
                    {
                        if (!book[player].ContainsKey(position))
                        {
                            book[player][position] = skill;
                        }
                        else
                        {
                            if (book[player].ContainsKey(position) && skill > book[player][position])
                            {
                                book[player][position] = skill;
                            }
                        }
                    }
                }
                else if (currentInput.Length == 3)
                {
                    string playerOne = currentInput[0];
                    string playerTwo = currentInput[2];

                    if (!book.ContainsKey(playerOne) || !book.ContainsKey(playerTwo))
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    List<string> firstPosition = new List<string>();
                    List<string> secondPosition = new List<string>();

                    foreach (var position in book[playerOne])
                    {
                        firstPosition.Add(position.Key);
                    }
                    foreach (var position in book[playerTwo])
                    {
                        secondPosition.Add(position.Key);
                    }

                    bool positionFound = false;
                    for (int i = 0; i < firstPosition.Count; i++)
                    {
                        string currentFirst = firstPosition[i];
                        for (int j = 0; j < secondPosition.Count; j++)
                        {
                            string currentSecond = secondPosition[j];
                            if (currentFirst == currentSecond)
                            {
                                positionFound = true;
                                break;
                            }
                        }
                    }

                    if (positionFound)
                    {
                        int playerOnePoint = book[playerOne].Values.Sum();
                        int playerTwoPoint = book[playerTwo].Values.Sum();

                        if (playerOnePoint > playerTwoPoint)
                        {
                            book.Remove(playerTwo);
                        }
                        else if (playerTwoPoint > playerOnePoint)
                        {
                            book.Remove(playerOne);
                        }
                    }

                }

                input = Console.ReadLine();


            }

            foreach (var currentPlayer in book.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currentPlayer.Key}: {currentPlayer.Value.Values.Sum()} skill");
                foreach (var currentPosition in currentPlayer.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {currentPosition.Key} <::> {currentPosition.Value}");
                }
            }
        }
    }
}
