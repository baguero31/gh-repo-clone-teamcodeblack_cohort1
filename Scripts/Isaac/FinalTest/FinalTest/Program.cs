using System;


namespace FinalTest
{
    /// <summary>
    /// Final Exam
    /// 
    /// This is your final C# exam.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * P1.  Create a NEW instance of the NameModel Class.
             *     Call the instance finalTest.  Provide the answer below.
             */
            NameModel finalTest = new NameModel();



            /*
             * P2. Using the assignment operator, set the 
             *    following values
             *    
             *    ID should have any number of the proper type
             *    First name should have your first name
             *    Last name should have your last name
             *    Address should have your address
             *    City should be Omaha
             *    State should be Nebraska
             *    Zip should contain your zipcode
             *    The date should be the current date, which is today.
             */

            int ID = -1;
            string FirstName = "Isaac";
            string LastName = "Reid";
            string Address = "Someplace";
            string City = "Omaha";
            string State = "Nebraska";
            string Zip = "3526485";
            DateTime CreatedDate = new DateTime();
            CreatedDate = DateTime.Now;

            /* 
             * P3. Set each finalTest property WITH THE VALUE of the types you 
             *    created in step 2.  Make corrections to place the 
             *    data into the property if needed.
             *    
             *    (Note - the NameModel class should not change)
             *
             *    Provide the answers below.
             */
            finalTest.ID = ID;
            finalTest.FirstName = FirstName;
            finalTest.LastName = LastName;
            finalTest.Address = Address;
            finalTest.City = City;
            finalTest.State = State;
            finalTest.Zip = Zip;
            finalTest.CreatedDate = CreatedDate;


            /*
             * P4. Write a conditional filter that looks for IDs that are greater than 
             *    and equal to 0.  If the condition evaluates to TRUE, then set the ID
             *    to 15.
             *    
             *    Provide the answers below.             *              
             */
            if (finalTest.ID >= 0)
            {
                finalTest.ID = 15;
            }
        /*
         * P5. Create a method titled FinalTestDone that accepts a string parameter
         *    and returns a boolean type.  Inside of the method, write a conditional
         *    that compares the parameter passed in to a value specified by yourself.
         *    
         *    Provide the answers below.
         */
        bool FinalTestDone(string str) {
                if (str != "hello")
                {
                    return false;
                }
                else
                {
                    return true;    
                }
            }
    }
    }
    internal class NameModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
