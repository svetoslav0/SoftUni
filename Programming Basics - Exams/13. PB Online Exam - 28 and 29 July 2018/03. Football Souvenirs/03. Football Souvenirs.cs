using System;

namespace _03._Football_Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double totalPrice = 0.0;

            if (country == "Argentina")
            {
                if (souvenir == "flags")
                {
                    totalPrice = count * 3.25;
                }
                else if (souvenir == "caps")
                {
                    totalPrice = count * 7.2;
                }
                else if (souvenir == "posters")
                {
                    totalPrice = count * 5.1;
                }
                else if (souvenir == "stickers")
                {
                    totalPrice = count * 1.25;
                }
            }
            else if (country == "Brazil")
            {
                if (souvenir == "flags")
                {
                    totalPrice = count * 4.2;
                }
                else if (souvenir == "caps")
                {
                    totalPrice = count * 8.5;
                }
                else if (souvenir == "posters")
                {
                    totalPrice = count * 5.35;
                }
                else if (souvenir == "stickers")
                {
                    totalPrice = count * 1.2;
                }
            }
            else if (country == "Croatia")
            {
                if (souvenir == "flags")
                {
                    totalPrice = count * 2.75;
                }
                else if (souvenir == "caps")
                {
                    totalPrice = count * 6.9;
                }
                else if (souvenir == "posters")
                {
                    totalPrice = count * 4.95;
                }
                else if (souvenir == "stickers")
                {
                    totalPrice = count * 1.1;
                }
            }
            else if (country == "Denmark")
            {
                if (souvenir == "flags")
                {
                    totalPrice = count * 3.1;
                }
                else if (souvenir == "caps")
                {
                    totalPrice = count * 6.5;
                }
                else if (souvenir == "posters")
                {
                    totalPrice = count * 4.8;
                }
                else if (souvenir == "stickers")
                {
                    totalPrice = count * 0.9;
                }
            }

            if (country != "Argentina" && country != "Brazil" && country != "Denmark" && country != "Croatia")
            {
                Console.WriteLine($"Invalid country!");
            }
            else if (souvenir != "flags" && souvenir != "caps" && souvenir != "posters" && souvenir != "stickers")
            {
                Console.WriteLine($"Invalid stock!");
            }
            else
            {
                Console.WriteLine($"Pepi bought {count} {souvenir} of {country} for {totalPrice:f2} lv.");
            }
        }
    }
}
