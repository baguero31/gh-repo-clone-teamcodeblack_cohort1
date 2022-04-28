using NUnit.Framework;
using WorkerClasses;
using HelloWorld;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Diagnostics;

namespace WorkerClassTests
{
    public class Tests
    {
        internal IWorkerClass testWorkClass;

        [SetUp]
        public void Setup()
        {           
            this.testWorkClass = new WorkerClass();
        }

        [Test]
        public void TestClear()
        {
            WorkerClass wc = new WorkerClass();

            wc.NameInfo = "Boo";
            wc.IsWorkable = true;
            wc.IdIndicator = 20;

            testWorkClass.Clear(wc);

            Assert.IsTrue(wc.NameInfo == string.Empty);
            Assert.IsTrue(wc.IsWorkable == false);
            Assert.IsTrue(wc.IdIndicator == 0);

        }
    }
}