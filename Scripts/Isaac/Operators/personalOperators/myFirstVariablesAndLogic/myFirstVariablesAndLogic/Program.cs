// See https://aka.ms/new-console-template for more information

using System;
namespace myFirstVariablesAndLogic{
    internal class Program1{

        public static void Main() {
            Console.WriteLine("Hello, World!");
            //assignments
            bool t;
            t = true;
            //^proof i understand independant assignment is possible
            bool f = false;
            int num5 = 5;
            int num7 = 7;
            long funnyNumber = 123456789;
            //numbers
            Console.WriteLine($"{num5 + num7}");
            Console.WriteLine($"{num5 - num7}");
            Console.WriteLine($"{num5 * num7}");
            Console.WriteLine($"{num5 / num7}");
            Console.WriteLine($"{Math.Pow(num5, num7)}");
            Console.WriteLine($"splicing numbers to get the values i want with mod {(funnyNumber % 100)}");//no easily found floored division i see
            
            //logic
            if (!t == f || t && false) {
                Console.WriteLine ($"should land here, value should be true since its an regular or");
            }
            else
            {
                Console.WriteLine($"soooo many brackets? what is this, lisp?");
            }
            if (!t == t ^ !f == f){
                Console.WriteLine("we dont land here instead of the other place because exclusive or");
            }
            else{
                Console.WriteLine("exclusive or gave us the else clause");
            }
            //also to prove i can do it
            bool falseResult = num5 > num7;
            Console.WriteLine($"false result is false: {falseResult}");
            //to be honest i understand it, but boy am i too tired right now to play around with the syntax at 11 @ night when i have the time
            //also i mayve accidentally let the ide teach me the syntax for if else statments
            Console.WriteLine("Aaaaand thats everything. i think");


        }
    }
 }