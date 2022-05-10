using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAndVarTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# Data Types
             * 
             * DATA TYPES can be known by many names (variables, containers, types).  In C#, 
             * you will use an abundance of different data types based on what you are attempting
             * to solve for.
             * 
             * C# is generally broken into two different types - Value Types and Reference Types
             * 
             * VALUE TYPES hold the data value inside its own memory space.  Value Types usually hold a value.
             * REFERENCE TYPES store the address of where the value is being stored.
             * 
             * Below are a few TYPES of Data Types that are available for you to use in C#
             * 
            */

            //Value Types
            bool isBool = true;
            byte AByte = 255;
            char BChar = 'C';
            decimal cDecimal = 100.00M;
            double cDouble = 114.5D;
            float cFloat = 113.5F;
            int cInt = 564646;
            long cLong = 564654654654654654;
            short cShort = 5165;

            //Reference Types
            string cString = "05165";

            short.TryParse(cString, out short newShort);

            string[] stringArr = new string[]
            {
                "Alex", "Brenda", "Zak", "Charity",
                "Chelle", "LaResha", "Isaac"
            };

            Console.WriteLine(stringArr[5]);

            List<string> stringList = new List<string>()
            {
                "Alex", "Brenda", "Zak", "Charity",
                "Chelle", "LaResha", "Isaac"
            };

            List<SomeClass> somes = new List<SomeClass>()
            {
                new SomeClass()
                {
                  SomeString = "This",
                  SomeInt = 0
                },
                new SomeClass()
                {
                    SomeString = "That",
                    SomeInt = 1
                }
            };


            var someInfo = "hello";
            string floatInfo = "999";

            var newInt = Convert.ToInt16(floatInfo);



        }
    }

    public class SomeClass
    {
        public string SomeString { get; set; }
        public int SomeInt { get; set; }
    }
}
