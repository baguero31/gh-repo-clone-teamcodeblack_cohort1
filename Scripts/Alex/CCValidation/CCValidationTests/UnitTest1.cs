using CCValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CCValidationTests
{
    [TestClass]
    public class UnitTest1
    {
        IValidationFunctions testValidation;

        [TestInitialize]
        public void TestInitialize()
        {
            testValidation = new ValidationFunctions();
        }

        [TestMethod]
        public void TestIsCardValid()
        {
            //invalid card
            //Assert.IsFalse(testValidation.IsCardValid("4624748233249080"));
            //Assert.IsTrue(testValidation.IsCardValid("4624748233249780"));

            List<string> testCards = new List<string>()
            {
                "6011000991001222",
                "6011000991001201",
                "6011111111111117",
                "6011000990139424",
                "4111111111111111",
                "4242424242424242",
                "4012888888881881",
                "5499740000000057",
                "5555555555554444",
                "5105105105105100",
                "378282246310005",
                "371449635398431",
                "378734493671000"
            };

            foreach (string cardNum in testCards)
            {
                var cardType = cardNum.Substring(0, 4);
                if (cardType.StartsWith("37"))
                {
                    Assert.IsTrue(testValidation.IsCardValid(cardNum, PlasticType.AMEX));
                }
                else if (cardType.StartsWith("4"))
                {
                    Assert.IsTrue(testValidation.IsCardValid(cardNum, PlasticType.Visa));
                }
                else if (cardType.StartsWith("5"))
                {
                    Assert.IsTrue(testValidation.IsCardValid(cardNum, PlasticType.MasterCard));
                }
                else if (cardType.StartsWith("6011"))
                {
                    if (cardNum.Contains("1222"))
                    {
                        Assert.IsFalse(testValidation.IsCardValid(cardNum, PlasticType.Discover));
                    }
                    else
                    {
                        Assert.IsTrue(testValidation.IsCardValid(cardNum, PlasticType.Discover));
                    }
                }
            }
        }
    }
}
