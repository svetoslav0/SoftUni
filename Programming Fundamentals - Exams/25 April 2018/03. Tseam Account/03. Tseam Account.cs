using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Tseam_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> account = Console.ReadLine().Split().ToList();

            string[] commands = Console.ReadLine().Split().ToArray();


            while (commands[0] != "Play!")
            {
                var currentCommand = commands[1];
                switch (commands[0])
                {
                    case "Install":
                        InstallGame(account, currentCommand);
                        break;
                    case "Uninstall":
                        UninsallGame(account, currentCommand);
                        break;
                    case "Update":
                        UpdateGame(account, currentCommand);
                        break;

                    case "Expansion":
                        ExpandGame(account, currentCommand);
                        break;
                }


                commands = Console.ReadLine().Split().ToArray();

            }

            Console.WriteLine(string.Join(" ", account));


        }

       

        public static List<string> InstallGame(List<string> account, string currentGame)
        {
            if (!account.Contains(currentGame))
            {
                account.Add(currentGame);
            }
            return account;
        }
        public static List<string> UninsallGame(List<string> account, string currentGame)
        {
            if (account.Contains(currentGame))
            {
                var index = account.IndexOf(currentGame);
                account.RemoveAt(index);
            }

            return account;
        }
        public static List<string> UpdateGame(List<string> account, string currentGame)
        {
            if (account.Contains(currentGame))
            {
                UninsallGame(account, currentGame);
                InstallGame(account, currentGame);
            }

            return account;
        }

        public static List<string> ExpandGame(List<string> account, string currentExpand)
        {
            var splitted = currentExpand.Split('-').ToArray();
            string currentGame = splitted[0];
            string expand = splitted[1];

            if (account.Contains(currentGame))
            {
                var index = account.IndexOf(currentGame);
                account.Insert(index + 1, $"{currentGame}:{expand}");

            }
            return account;
        }
    }
}
