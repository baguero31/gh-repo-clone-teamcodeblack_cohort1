using System;
using System.Linq;

namespace PalindromeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string quitString = "Y";
            string inputWord;

            Console.WriteLine("Hello! Welcome to the Palindrome Checker!");
            Console.WriteLine();

            while (quitString.Equals("Y"))
            {
                Console.WriteLine("Type in a word to check if it is a Palindrome.");
                Console.WriteLine("Press enter after you are done.");
                inputWord = Console.ReadLine();


                if (string.IsNullOrEmpty(inputWord))
                {
                    Console.WriteLine($"You did not enter a word. Try again.");
                }
                else if (IsPalinDrome(inputWord))
                {
                    Console.WriteLine($"The word {inputWord} IS a Palindrome!");
                }
                else
                {
                    Console.WriteLine($"The word {inputWord} IS NOT a Palindrome!");
                }

                Console.WriteLine();
                Console.WriteLine("Press Y to continue, Press Q to quit");
                quitString = Console.ReadLine();

                switch (quitString.ToUpper())
                {
                    case "Y":
                        break;

                    case "Q":
                        break;

                    default:
                        quitString = "Y";
                        break;
                }
                
                Console.Clear();
            }
        }

        static bool IsPalinDrome(string word)
        {
            string reversedWord = string.Empty;
            var reverseWord = word.Reverse();

            foreach (char c in reverseWord)
            {
                reversedWord += c;
            }

            return word.ToUpper().Equals(reversedWord.ToUpper());
        }
    }
}
