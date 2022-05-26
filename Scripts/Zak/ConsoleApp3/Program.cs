     using System;

namespace ConsoleApp3
{
    internal class Program
    {
        private static bool result;

        static void Main(string[] args)
        {
            int a = 2; 
            int b = 3;
            int e = 6 - 5;
            int c = 4;
            int d = 5 + 4;
            bool f = false;
            bool t = true;
            
            Console.WriteLine(a + b);
            Console.WriteLine(a - c);
            Console.WriteLine(b > a);
            Console.WriteLine(d++);
            Console.WriteLine(++e);
            Console.WriteLine(d--);
            Console.WriteLine(--e); 
            Console.WriteLine($"a is greater than b: {a > b}");
            Console.WriteLine($"the product of a times c is: {a * c}");
            Console.WriteLine($"remainder of c divded by b: {c % b}");
            Console.WriteLine($"a is greater than b: {!(a > b)}");
            result = f & t;
            Console.WriteLine($"f & t: {result}"); 
            Console.WriteLine($"t ^ f: {t ^ f}");
            

        }
    }
}
