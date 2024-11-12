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
    public class EducationAssert : CommonDriver
    {
        private static IWebElement messageBox => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        static string  expectedMessage1 = "Education has been added";
       static string expectedMessage2 = "please enter all the fields";
       static string expectedMessage3 = "This information is already exist.";
        static string expectedMessage4 = "Education entry successfully removed";

        public static void AddEducationAssert()
        {
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            
           

            Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3));

        }
        public static void DeleteEducationAssert()
        {
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            


            Assert.That(actualMessage, Is.EqualTo(expectedMessage4));

        }
    }
}
