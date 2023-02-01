using System;

namespace QuoteWords
{
    // Class header:
    // Author: Yanzhi Wang
    // Purpose: This class contains the program entry point.
    // Restrictions: None known.
    class Program
    {
        // Method header:
        // Purpose: This method is the main program logic. It prompts the user for input and passes the input to the QuoteWords method for processing.
        // Restrictions: None known.
        // Other appropriate sections: None applicable.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Console.WriteLine("Quoted string:");
            Console.WriteLine(QuoteWords(input));
        }

        // Method header:
        // Purpose: This method accepts a string as input and returns the same string with double quotes added around each word.
        // Restrictions: None known.
        // Other appropriate sections:
        // - Parameters:
        //   - string input: the string to be processed
        // - Return values:
        //   - string: the processed string with double quotes around each word
        static string QuoteWords(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = "\"" + words[i] + "\"";
            }
            return string.Join(" ", words);
        }
    }
}
