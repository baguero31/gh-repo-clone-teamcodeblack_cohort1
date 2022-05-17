using System;

namespace PalindromeTester
{
    /// <summary>
    /// PalindromeTester
    /// 
    /// Authored by:
    /// R. Walker, I. Reid, C. Mondi, Z. Rab
    /// 
    /// Reviewed by:
    /// A. Horton
    /// 
    /// </summary>
    internal class Program
    {
        //1. Create a container - DONE **
        public static string PalindromeInput { get; set; }

        static void Main(string[] args)
        {
            //6. Prompt if they want to input another word
            string continueLoop = "Y"; //Wants to continue

            while (continueLoop == "Y")
            {
                //2. Prompt User for input
                Console.WriteLine("Input Word:");
                Console.WriteLine();

                //3. Gather Input
                PalindromeInput = Console.ReadLine().ToLower(); //Gathers input from the user

                //4. Run Algo
                if (PalindromeAl())
                {
                    //5. Give output to user
                    Console.WriteLine("Word is a Palindrome");
                }
                else
                {
                    Console.WriteLine("Word ain't a Palindrome");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press Y to continue, Q to quit");
                continueLoop = Console.ReadLine().ToUpper();
            }

        }

        public static bool PalindromeAl()
        {
            if (string.IsNullOrEmpty(PalindromeInput))
                return false;

            string input = string.Empty;

            for (int i = PalindromeInput.Length - 1; i >= 0; i--)
            {
                input += PalindromeInput[i].ToString();
            }

            return input == PalindromeInput;
        }

    }
}
