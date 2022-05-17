using System;

namespace CC_95
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Assingment Operator
            int a, b;
            string StringA;
            string StringB;
            a = 4;
            b = 5;
            bool areSkiesBlue;
            bool areGrassGreen;
            bool result;

            int c = 8;

            #endregion

            #region Arithmetic/Comparison Operator

            #region Comparison Operator

            areSkiesBlue = a>=b;
            Console.WriteLine($"Value Of areSkiesBlue: {areSkiesBlue}");
            Console.WriteLine();

            areSkiesBlue = a < b;
            Console.WriteLine($"Value of areSkiesBlue: {areSkiesBlue}");
            Console.WriteLine();

            Console.Clear();

            #endregion

            #endregion

            #region Arithmetic Operator

            a = 5 + 3;
            b = 20 - 5;

            #endregion 

            #region Addition

            Console.WriteLine("Addition");
            Console.WriteLine($"current value of a: {a}");

            Console.WriteLine($"current value of b: {b}");
            #endregion 

            #region Subtraction

            Console.WriteLine("Subtraction");
            Console.WriteLine($"current value of a: {a}");

            Console.WriteLine($"current value of b: {b}");

            #endregion 

            #region Unary

            a = +8;
            b = -8;
            Console.WriteLine($"Unary value of a: {a}");
            Console.WriteLine($"Unary value of b: {b}");
            Console.WriteLine();

            #endregion 

            #region Multiplication
            a = 7 * 2;
            b = 11 * 5;
            Console.WriteLine($"Product of a: {a}");
            Console.WriteLine($"Product of b: {b}");
            Console.WriteLine();

            #endregion 

            #region Division

            a = 24 / 3;
            b = 6 / 2;
            Console.WriteLine($"Product of a: {a}");
            Console.WriteLine($"Product of b: {b}");
            Console.WriteLine();

            #endregion 

            #region Modulus
            a = 10 % 3;
            Console.WriteLine($"Remainder of 10 mod 3: {a}");
            Console.WriteLine();

            #endregion 

            #region Boolean

            areGrassGreen = true;

            Console.WriteLine(areGrassGreen);
            Console.WriteLine(!areGrassGreen);
            Console.WriteLine();

            #endregion 

            #region Equality

            a = 8;
            b = 12;

            result = a == b;

            Console.WriteLine($"Equality Operator (==) - Result is {result}");
            Console.WriteLine();

            a = 10;
            b = 10;

            result = a == b;

            Console.WriteLine($"Equality Operator (==) - Result is {result}");
            Console.WriteLine();

            #endregion 
        }
    }
}
