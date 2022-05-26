using System;
using System.Collections.Generic;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Conditionals
             * 
             * "He who fails to plan is planning to fail."
             *  -Winston Churchill
             * 
             * Everybody - yes EVERYBODY - uses basic logic in their everyday life. There are no exceptions.
             * 
             * "If I get the bean burrito, then something bad could happen"
             * "If we don't get this work done, then we will have to work late."
             * 
             * Even our parents used basic logic while they raised us:
             * "If you don't sit yourself down and hush, then <insert swift reprucussions here>"
             * 
             * The same rule applies to when we are using most programming languages.  The only difference is
             * HOW we tell the computer to handle that logic.
             * 
             * Let's look at a few examples of conditionals below with 
             * If conditionals and loops 
             * 
             */

            bool isConditionTrue = false;

            #region IF/Else/ElseIF
            DateTime conditionalDate = new DateTime(2022, 5, 12, 8, 12, 00);

            //if conditional
            if (conditionalDate.Hour >= 11)
            {
                isConditionTrue = true;
            }

            if (conditionalDate.Hour >= 11)
            {
                //execute this logic
                isConditionTrue = true;
            }
            else
            {
                //execute this logic here
                isConditionTrue = false;
            }

            if (conditionalDate.Hour >= 11)
            {
                isConditionTrue = true;
            }
            else if (conditionalDate.Minute <= 11)
            {
                isConditionTrue = true;
            }
            else
            {
                isConditionTrue = false;
            }
            #endregion

            #region While Loop

            int counter = 28;
            int x = 0;
            string useString = @"IT'S A GOOD DAY TO BE HAPPY!";
            string newString = string.Empty;

            while (counter > 0)
            {
                newString += useString.Substring(x, 1);
                if (newString.Contains("DAY"))
                {
                    counter = 0;
                }
                counter--;
                x++;
            }
            #endregion

            #region Do/While Loops
            counter = 28;
            x = 0;
            useString = @"IT'S A GOOD DAY TO BE HAPPY!";
            newString = string.Empty;

            do
            {
                newString += useString.Substring(x, 1);
                if (newString.Contains("DAY"))
                {
                    counter = 0;
                }
                counter--;
                x++;
            } while (counter > 0);
            #endregion

            #region For Loops
            useString = @"IT'S A GOOD DAY TO BE HAPPY!";
            newString = string.Empty;
            string reverseString = string.Empty;

            for (int i = 0; i < useString.Length; i++)
            {
                if (newString.Contains("DAY"))
                {
                    break;
                    //continue;
                }
                else
                {
                    newString += useString[i];
                }
            }

            for (int i = useString.Length - 1; i >= 0; i--)
            {
                reverseString += useString[i];
            }
            #endregion

            #region ForEach looping

            newString = string.Empty;
            useString = @"IT'S A GOOD DAY TO BE HAPPY!";

            foreach (var letter in useString)
            {
                newString += letter;
            }

            List<TestClass> listOfClasses = new List<TestClass>()
            {
                new TestClass()
                {
                     MyBProperty = false,
                     MyProperty = 1,
                     MySProperty = "You"
                },
                new TestClass()
                {
                     MyBProperty = false,
                     MyProperty = 2,
                     MySProperty = "Can't"
                },
                new TestClass()
                {
                     MyBProperty = false,
                     MyProperty = 3,
                     MySProperty = "Handle"
                },
                new TestClass()
                {
                     MyBProperty = false,
                     MyProperty = 4,
                     MySProperty = "The"
                },
                new TestClass()
                {
                     MyBProperty = true,
                     MyProperty = 5,
                     MySProperty = "Truth!"
                }
            };

            foreach (var item in listOfClasses)
            {
                Console.WriteLine(item.MySProperty);
            }

            #endregion

        }
    }

    internal class TestClass
    {
        public int MyProperty { get; set; }
        public string MySProperty { get; set; }
        public bool MyBProperty { get; set; }

    }
}
