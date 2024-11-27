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
    public class PasswordAssert : CommonDriver
    {
        private static IWebElement messageBox => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        static string expectedMessage1 = "Password Changed Successfully";

        public static void AddPasswordAssert()
        {
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage, Is.EqualTo(expectedMessage1));

        }
    }
}
