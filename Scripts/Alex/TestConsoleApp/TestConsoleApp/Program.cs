using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using TestOutside;

namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Outside outside = new Outside();

            string baton = "iguess";
            bool isBaton = false;
            string answer1 = string.Empty;

            int guess = outside.Starter(baton);  //starting of the 4 x 100

            if (guess == 2)
            {
                answer1 = outside.SecondLeg(baton);
            }
            if (isBaton = outside.ThirdLeg(answer1))
            {
                baton = "guessagain";
            }
            string finish = outside.AnchorLeg(baton);





            Console.WriteLine("Hello World!");

            string vendorList = @"
1,Farrell Fritsch and Anderson,Miscellaneous
2,Schroeder-Murazik,Consumer Services
3,Littel-Jerde,Consumer Non-Durables
4,Schuster Walker and Hirthe,Technology
5,Volkman Cruickshank and Cormier,Energy
6,Pagac Bernier and Reichert,Public Utilities
7,Hilll-Prohaska,Consumer Non-Durables
8,Doyle Weimann and Ratke,n/a
9,Bins-Volkman,Miscellaneous
10,Marvin-Ward,Capital Goods";

            Vendors vendor = new Vendors();

            vendor.AddVendor(vendorList);


        }

    }

    internal class Vendors
    {
        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public string VendorType { get; set; }




        public void AddVendor(string pData)
        {
            List<Vendors> vList1 = new List<Vendors>();
            Vendors vs;


            using (StringReader reader = new StringReader(pData))
            {
                reader.ReadLine();
                int count = 0;
                byte dashCount = 0;

                string line = string.Empty;

                while ((line = reader.ReadLine()) != null)
                {
                    var splitData = line.Split(',').ToArray();

                    if (int.TryParse(splitData[0], out int venId))
                    {
                        if (splitData[1].Contains("-"))
                        {
                            dashCount++;
                        }
                        if (splitData[2].Contains("-"))
                        {
                            dashCount++;
                        }

                        vs = new Vendors()
                        {
                            VendorID = venId,
                            VendorName = splitData[1],
                            VendorType = splitData[2]
                        };                        

                        vList1.Add(vs);
                    }

                    count++;
                }
                Console.WriteLine($"There are {dashCount} dashes in the data.");

            }

        }


    }

}
