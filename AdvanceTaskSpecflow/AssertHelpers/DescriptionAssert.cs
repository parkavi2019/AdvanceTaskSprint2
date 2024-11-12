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
    public class DescriptionAssert : CommonDriver
    {
        private static IWebElement messageBox => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        static string expectedMessage1 = "Description has been saved successfully";
        static string expectedMessage2 = "First character can only be digit or letters";
        public static void AddDescriptionAssert()
        {
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);



            Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2));

        }
    }
}
