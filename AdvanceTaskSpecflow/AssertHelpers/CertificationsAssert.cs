using AdvanceTaskSpecflow.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskSpecflow.AssertHelpers
{
    public class CertificationsAssert : CommonDriver
    {
        private static IWebElement messageBox => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        static string expectedMessage1 = "J2EE has been added to your certification";
        static string expectedMessage2 = "Please enter Certification Name,Certification From and Certification Year";
        static string expectedMessage3 = "This information is already exist.";
        static string expectedMessage4 = "J2EE has been deleted from your certification";

        public static void AddCertificationAssert()
        {
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);



            Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3).Or.EqualTo(expectedMessage4));

        }
        public static void DeleteCertificationAssert()
        {
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);



            Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3).Or.EqualTo(expectedMessage4));

        }
    }
}
