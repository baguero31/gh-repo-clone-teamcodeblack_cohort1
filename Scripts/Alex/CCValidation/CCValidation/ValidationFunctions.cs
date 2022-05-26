using System;
using System.Collections.Generic;
using System.Linq;


/*
 * Luhn's algorithm

Luhn's algorithm determines whether or not a credit card number is valid. For a given credit card number:

    Double the value of every other digit from right to left, beginning with the second to last digit.
    Add the digits of the results of Step 1 to the remaining digits in the credit card number.
    If the result mod 10 is equal to 0, the number is valid. If the result mod 10 is not equal to 0, the validation fails.

    Example

    A credit card of type Visa is added with the number 4624 7482 3324 9080.

    This credit card number starts with 4, as it should be in all Visa cards. It also has 16 digits, which is valid for a Visa card. Now, execute Luhn's algorithm:
        Double the value of every other digit from right to left, beginning with the second to last digit.

        4624 7482 3324 9080:
            8*2 = 16
            9*2 = 18
            2*2 = 4
            3*2 = 6
            8*2 = 16
            7*2 = 14
            2*2 = 4
            4*2 = 8
        Add the digits of the results of the previous step to the remaining digits in the credit card number.
            The digits of the result of Step a amount to the following:
            1+6+1+8+4+6+1+6+1+4+4+8 = 50
            The remaining digits in the credit card number amount to the following:
            6+4+4+2+3+4+0+0 = 23
            The sum of the two sub results is:
            23+50 = 73
        If the result mod 10 is equal to 0, the number is valid. If the result mod 10 is not equal to 0, the validation fails.

        73 mod 10 is 3, therefore the card number is not valid.

        A Visa credit card of number 4624 7482 3324 9780, on the other hand, passes the validation.
 */
namespace CCValidation
{
    public interface IValidationFunctions
    {
        bool IsCardValid(string pCardNumber, PlasticType card);
    }

    public enum PlasticType
    {
        Visa = 1,
        MasterCard = 2,
        Discover = 3,
        AMEX = 4
    }

    /// <summary>
    /// This class uses an algorithm called Luhn's Algorithm.
    /// The logic is used below:
    /// </summary>
    public class ValidationFunctions : IValidationFunctions
    {
        /// <summary>
        /// Method that evaluates if a card is a valid card number.  Also outputs the type of card as well
        /// </summary>
        /// <param name="pCardNumber">Passed in Card number</param>
        /// <param name="card">Card Type Enumeration</param>
        /// <returns>bool</returns>
        public bool IsCardValid(string pCardNumber, PlasticType card)
        {
            string cType = string.Empty; //display the type of card here.
            int cardLen = 15; //for the last byte, which is a check digit

            //1. Reverse the card number (so 4624 7482 3324 9080 is now 0809 4233 2847 4264)
            var revCardNum = pCardNumber.Substring(0, cardLen).Reverse().ToArray();
            var revCardPositive = pCardNumber.Reverse().ToArray();
            var cardType = pCardNumber.Substring(0, 4);
            string[] numList = new string[] { };
            int cardNumCount = 0;
            int oProduct = 0;
            List<int> runningTotal = new List<int>();
            List<int> runningOTotal = new List<int>();
            int mainDigits = 0;

            //2. Determine the type of card
            if (pCardNumber.Length < 4)
            {
                //first, find the length of the card
                Console.WriteLine($"Card is an invalid length - try again");
                return false;
            }
            else
            {
                //next, find the type of the card
                if (cardType.StartsWith("37") && pCardNumber.Length == 15 && card.Equals(PlasticType.AMEX))
                {
                    cType = "AMEX";
                    cardLen = 14;
                }
            }

            while (cardNumCount < cardLen)
            {
                //3. Get the sum of every other number starting with what is now the last digit
                for (int i = 0; i <= cardLen; i += 2)
                {
                    if (int.TryParse(revCardPositive[i].ToString(), out int oCardNum))
                    {
                        runningOTotal.Add(oCardNum);
                    }
                }

                if (cardType.StartsWith("37")) cardLen--; //Have to subtract 1 for AMEX cards or you get out of bounds error

                //4. Do the math on the 15 numbers that remain with every other number
                for (int i = cType == "AMEX" ? 1 : 0; i <= cardLen; i += 2)
                {
                    if (int.TryParse(revCardNum[i].ToString(), out int cardNum)
                        && revCardNum[i].ToString().Length == 1)
                    {
                        //multiply the number by 2
                        oProduct = cardNum * 2;
                        runningTotal.Add(oProduct);
                    }
                    cardNumCount += i;
                }
            }

            //5. Next, do the math on the first group of numbers
            foreach (var firstDigits in runningTotal)
            {
                if (firstDigits > 9)
                {
                    var intList = firstDigits.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
                    mainDigits += intList[0] + intList[1];
                }
                else
                {
                    mainDigits += firstDigits;
                }
            }

            //6. Now, add the remaining numbers together with the first set
            var checkTotal = runningOTotal.Sum() + mainDigits;

            //7. Finally, get the remainder and output the result
            int result = checkTotal % 10;

            return result == 0;
        }

    }
}
