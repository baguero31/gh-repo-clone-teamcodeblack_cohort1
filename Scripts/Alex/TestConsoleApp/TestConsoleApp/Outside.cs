using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOutside
{
    internal class Outside
    {
        private string passWord = "MyPassword123";
        int MyProperty { get; set; }

        internal int Starter(string baton)
        {

            if (baton.Equals(passWord))
            {
                MyProperty = 1;
            }
            else
            {
                MyProperty = 2;
            }

            return MyProperty;
        }

        internal string SecondLeg(string baton)
        {
            if (baton.Contains("guess"))
            {
                return baton;
            }
            else
            {
                return "almost";
            }
        }

        internal bool ThirdLeg(string baton)
        {
            if (!baton.Contains("guess"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal string AnchorLeg(string baton)
        {
            if (baton.Length > 5)
            {
                return "Finished";
            }
            else
            {
                return "Not Finished";
            }
        }




        void SomeOtherMethod()
        {
            MyProperty = 1;

            string someString = "";
        }

    }
}
