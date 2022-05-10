using Operators.Model;
using System;

namespace Operators
{
    internal class Program
    {
        /*
         * Operators (not Sade)
         * 
         * What are operators?  An operator in C# allows you to interact with the types that
         * you will create and utilize during your code writing.
         * 
         * Arithmetic operators: perform arithmetic on numbers
         * Comparison operators: compare numbers to one another
         * Boolean Logical operators: check if a boolean is true or false
         * Bitwise/Shift operators: that perform bitwise/shift operations certain types
         * Equality operators: checks to see if two types are equal to one another
         * 
         * Not rocket science, folks.
         * 
         * 10 > 12 = true or false?
         * The word "boo" is equal to the word "boot" = true or false?
         *  
         */

        static void Main(string[] args)
        {
            #region Assignment Operator (=)
            /*
             * The assignment operator gives variables, properties, or indexers their 
             * value.  This is called INITIALIZATION.
             */

            int a, b; //a and b are created and are defaulted to 0 (they're numbers)
            string stringA; //strings are NULL by default (has no value).
            string stringB;
            a = 1; //a is set to 1
            b = 2; //b is set to 2
            //booleans are set to false by default.
            bool areNumbersEqual;
            bool areObjectsEqual;
            bool result;

            //you can also assign values to variables when you create them.  
            int c = 5;

            #endregion

            #region Arithmetic/Comparison Operators
            //Debug the code below starting on line 35. What is the outcome of each evaluation?

            #region Comparison Operators
            //using comparison operators on numbers
            areNumbersEqual = a >= b;
            Console.WriteLine($"Value of areNumbersEqual: {areNumbersEqual}");
            Console.WriteLine();

            areNumbersEqual = a < b;
            Console.WriteLine($"Value of areNumbersEqual: {areNumbersEqual}");
            Console.WriteLine();

            areNumbersEqual = a > b;
            Console.WriteLine($"Value of areNumbersEqual: {areNumbersEqual}");
            Console.WriteLine();

            #endregion

            Console.Clear();

            #region Arithmetic Operators
            //using arithmetic operators
            a = 10 + 8;
            b = 32 - 20;

            //Addition and subtraction
            //postfix increment
            Console.WriteLine($"Value of a: {a}");
            Console.WriteLine($"Value of b: {b}");
            Console.WriteLine();

            //Increment Operator (++)
            //postfix increment
            Console.WriteLine("Addition");
            Console.WriteLine($"current value of a: {a}");
            Console.WriteLine($"value of a - postfix: {a++}"); //execute code first THEN add
            Console.WriteLine($"new value of a: {a}");

            //prefix increment
            Console.WriteLine($"current value of b: {b}");
            Console.WriteLine($"value of b - prefix: {++b}");
            Console.WriteLine($"new value of b: {b}");
            Console.WriteLine();

            //Decrement Operator (--)
            //postfix decrement (subtract)
            Console.WriteLine("Subtraction");
            Console.WriteLine($"current value of a: {a}");
            Console.WriteLine($"value of a - postfix: {a--}"); //execute code first THEN subtract
            Console.WriteLine($"new value of a: {a}");

            //prefix decrement (subtract)
            Console.WriteLine($"current value of b: {b}");
            Console.WriteLine($"value of b - prefix: {--b}");
            Console.WriteLine($"new value of b: {b}");
            Console.WriteLine();

            //Unary operator (+ may not use this a ton)
            a = +3;
            b = -3;
            Console.WriteLine($"Unary value of a: {a}");
            Console.WriteLine($"Unary value of b: {b}");
            Console.WriteLine();

            //multiplication operator (*)
            a = 10 * 5;
            b = 10 * 8;
            Console.WriteLine($"Product of a: {a}");
            Console.WriteLine($"Product of b: {b}");
            Console.WriteLine();

            //division operator (/)
            a = 25 / 5;
            b = 48 / 8;
            Console.WriteLine($"Product of a: {a}");
            Console.WriteLine($"Product of b: {b}");
            Console.WriteLine();

            //Modulus operator (% remainder) 
            a = 32 % 3;
            Console.WriteLine($"Remainder of 32 mod 3: {a}");
            Console.WriteLine();
            #endregion
            Console.Clear();

            #region Divide by Zero (BAD BAD THINGS)
            //Divide by zero = BAD BAD JUJU
            a = 34;
            b = 0;
            Console.WriteLine($"Try to Divide by zero { a / b }"); //exception city
            #endregion
            #endregion



            Console.Clear();

            #region Boolean Logical Operators
            /*
             * You will use these all of the time in conditionals!             
             */
            #region Logical negation
            //logical negation operator (!) - basically, the ! is the word NOT here.
            areObjectsEqual = true;

            Console.WriteLine(areObjectsEqual); //True
            Console.WriteLine(!areObjectsEqual); //NOT True (false)
            Console.WriteLine();

            #endregion

            Console.Clear();

            #region Logical And (& - returns a true value if both evaluate to true)

            areNumbersEqual = false;
            areObjectsEqual = false;

            result = areNumbersEqual & areObjectsEqual; //false

            Console.WriteLine($"Logical & - Result is {result}");
            Console.WriteLine();

            //change one to true
            areNumbersEqual = true;
            result = areNumbersEqual & areObjectsEqual; //false

            Console.WriteLine($"Logical & - Result is {result}");
            Console.WriteLine();

            //change both to true
            areObjectsEqual = true;
            result = areNumbersEqual & areObjectsEqual; //true

            Console.WriteLine($"Logical & - Result is {result}");
            Console.WriteLine();
            #endregion

            Console.Clear();

            #region Logical exclusive Or (^ - returns a false value if ONE evaluates to true) 
            /* same as the != operator! */

            areNumbersEqual = false;
            areObjectsEqual = false;

            result = areNumbersEqual ^ areObjectsEqual; //false

            Console.WriteLine($"Logical exclusive ^ - Result is {result}");
            Console.WriteLine();

            //change one to true
            areNumbersEqual = true;
            result = areNumbersEqual ^ areObjectsEqual; //true

            Console.WriteLine($"Logical exclusive ^ - Result is {result}");
            Console.WriteLine();

            //change both to true
            areObjectsEqual = true;
            result = areNumbersEqual ^ areObjectsEqual; //false

            Console.WriteLine($"Logical exclusive ^ - Result is {result}");
            Console.WriteLine();

            #endregion

            Console.Clear();

            #region Logical Or (| - returns true if EITHER of the values is true )

            areNumbersEqual = false;
            areObjectsEqual = false;

            result = areNumbersEqual | areObjectsEqual; //false

            Console.WriteLine($"Logical OR | - Result is {result}");
            Console.WriteLine();

            //change one to true
            areNumbersEqual = true;
            result = areNumbersEqual | areObjectsEqual; //true

            Console.WriteLine($"Logical OR | - Result is {result}");
            Console.WriteLine();

            //change both to true
            areObjectsEqual = true;
            result = areNumbersEqual | areObjectsEqual; //true

            Console.WriteLine($"Logical OR | - Result is {result}");
            Console.WriteLine();


            #endregion

            Console.Clear();

            #region Conditional Logical AND (&& - returns true if EITHER of the values is true )
            /* 
             * a/k/a "Short Circuiting - this one is used quite often.
             * If both operands evalute to true, then the result is true, otherwise it's false.
             * The short circuiting comes into play if the first operand is false, then
             * the second one isn't even looked at.
             * 
             */

            areNumbersEqual = false;
            areObjectsEqual = false;

            result = areNumbersEqual && areObjectsEqual; //false

            Console.WriteLine($"Conditional Logical AND && - Result is {result}");
            Console.WriteLine();

            //change one to true
            areNumbersEqual = true;
            result = areNumbersEqual && areObjectsEqual; //false (areObjectsEqual is false)

            Console.WriteLine($"Conditional Logical AND && - Result is {result}");
            Console.WriteLine();

            //change the other to true, change the second to false
            areNumbersEqual = false;
            areObjectsEqual = true;
            result = areNumbersEqual && areObjectsEqual; //false (areObjectsEqual is ignored)

            Console.WriteLine($"Conditional Logical AND && - Result is {result}");
            Console.WriteLine();

            //change both to true
            areNumbersEqual = true;
            result = areNumbersEqual && areObjectsEqual; //true

            Console.WriteLine($"Conditional Logical AND && - Result is {result}");
            Console.WriteLine();


            #endregion

            Console.Clear();

            #region Conditional Logical OR (|| - returns true if EITHER of the values is true )
            /* 
             * a/k/a "Short Circuiting - this one is used quite often as well.
             * If both operands evalute to true, then the result is true, otherwise it's false.
             * The short circuiting comes into play if the first operand is TRUE, then
             * the second one isn't even looked at.
             * 
             */

            areNumbersEqual = false;
            areObjectsEqual = false;

            result = areNumbersEqual || areObjectsEqual; //false

            Console.WriteLine($"Conditional Logical OR || - Result is {result}");
            Console.WriteLine();

            //change one to true
            areNumbersEqual = true;
            result = areNumbersEqual || areObjectsEqual; //true (areObjectsEqual is ignored)

            Console.WriteLine($"Conditional Logical OR || - Result is {result}");
            Console.WriteLine();

            //change the other to true, change the second to false
            areNumbersEqual = false;
            areObjectsEqual = true;
            result = areNumbersEqual || areObjectsEqual; //true (areObjectsEqual is true)

            Console.WriteLine($"Conditional Logical OR || - Result is {result}");
            Console.WriteLine();

            //change both to true
            areNumbersEqual = true;
            result = areNumbersEqual || areObjectsEqual; //true

            Console.WriteLine($"Conditional Logical OR || - Result is {result}");
            Console.WriteLine();


            #endregion

            Console.Clear();
            #endregion

            Console.Clear();

            #region Equality Operators
            /*
             * Equality and Inequality Operators produce boolean values that can be used
             * in conditionals to see if two operands are equal.  You can 
             * also use the operator to set boolean values.
             */

            result = false;
            areNumbersEqual = false;
            areObjectsEqual = false;

            #region Equality Operator (==)
            a = 10; //this is an ASSIGNMENT operator, not an equality operator
            b = 15; //so is this one!

            result = a == b;

            Console.WriteLine($"Equality Operator (==) - Result is {result}"); //false
            Console.WriteLine();

            a = 45; //set to the same
            b = 45;

            result = a == b;

            Console.WriteLine($"Equality Operator (==) - Result is {result}"); //true
            Console.WriteLine();


            #endregion

            Console.Clear();

            #region String Equality Operator (operand.Equals(string Operand))
            /*
             * Comparing two strings is the same, however, since String is a class, it 
             * contains an Equals method in which you can pass a second string as a 
             * parameter...
             */

            stringA = "hello world!";
            stringB = "HELLO WORLD!";

            result = stringA.Equals(stringB);

            Console.WriteLine($"String.Equals() - Result is {result}"); //false
            Console.WriteLine();

            stringA = "HELLO WORLD!";

            result = stringA.Equals(stringB);

            Console.WriteLine($"String.Equals() - Result is {result}"); //true
            Console.WriteLine();

            #endregion

            Console.Clear();

            #region Inequality Operator (!=)
            a = 12; //Again, this is an ASSIGNMENT operator, not an equality operator
            b = 16; //Don't get confused!

            result = a != b;

            Console.WriteLine($"Inequality Operator (!=) - Result is {result}"); //true
            Console.WriteLine();

            a = 45; //set to the same
            b = 45;

            result = a != b;

            Console.WriteLine($"Inequality Operator (!=) - Result is {result}"); //false
            Console.WriteLine();

            /*
             * For strings, you can also use logical negation just like a boolean 
             * (it returns a boolean)
             */

            stringA = "Is your head spinning yet?";
            stringB = "It sure is!";

            result = !stringA.Equals(stringB); //This reads as NOT stringA equals stringB

            Console.WriteLine($"String.Equals() - Result is {result}"); //true
            Console.WriteLine();

            #endregion

            #endregion

            Console.Clear();

            #region New Operator (creating new instances of types)
            /*
             * You will use the New operator to create a new instace of any reference, value, 
             * or Object type
             */

            #region New Value Type

            string newValueString = new string("Hello World!");
            Console.WriteLine($"Value of newValueString: {newValueString}");
            Console.WriteLine();

            //this is the same as above, however (and much more efficient)
            string otherNewValueString = "Hello World Again!";
            Console.WriteLine($"Value of otherNewValueString: {otherNewValueString}");
            Console.WriteLine();



            #endregion

            Console.Clear();

            #region New Reference Type
            /*
             * In this instance, the new Keyword creates a new instance of the OperatorClass
             * It also gives you the ability to use all of the properties, methods, and attributes
             * that are contained in the OperatorClass.
             */

            OperatorClass opClass = new OperatorClass()
            {
                OpClassByteProp = 1,
                OpClassShortProp = 300,
                OpClassIntProp = 15550,
                OpClassLongProp = 12565468550,
                IsOpClassBoolProp = true,
                OpClassString = "This is the string"
            };

            //now, you REFERENCE the type in memory that you created
            Console.WriteLine($"Value of opClassShortProp is {opClass.OpClassShortProp}");

            //You can also create what is called anonymous types with the new keyword

            var booYah = new { boo = "boo", yah = "yah" };

            Console.WriteLine($"Value of boo: {booYah.boo}");
            Console.WriteLine($"Value of yah: {booYah.yah}");
            Console.WriteLine();

            #endregion

            #endregion
        }
    }
}
