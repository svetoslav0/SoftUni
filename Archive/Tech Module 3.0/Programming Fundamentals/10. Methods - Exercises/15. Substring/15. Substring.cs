using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        const char Search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == Search)
            {
                hasMatch = true;

                int endIndex = n + 1;

                if (endIndex + i >= text.Length)
                {
                    endIndex = n;
                }

                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i += n;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
