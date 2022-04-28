using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        HelloMain testMain;

        [TestInitialize]
        public void TestSetup()
        {
            this.testMain = new HelloMain();  
        }

        [TestMethod]
        public void TestMethod1()
        {
            testMain.RunMain();
        }
    }
}
