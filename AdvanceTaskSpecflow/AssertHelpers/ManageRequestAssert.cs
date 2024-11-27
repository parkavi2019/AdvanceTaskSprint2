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
    public class ManageRequestAssert : CommonDriver
    {
       
       private static IWebElement messageBox => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
      
       // private static IWebElement messageBox => driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[2]/td[1]"));
      //  private static IWebElement messageBox => driver.FindElement(By.XPath("//tbody/tr[2]/td[1]"));
        private static IWebElement messageBox1 => driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/label"));
        static string expectedMessage1 = "Write a message to the seller";
        static string expectedMessage2 = "Request has been updated";
        static string expectedMessage3 = "Full Name:\r\nparkavi rajesh";
        public static void RecivedRequestAssert()
        {
            Thread.Sleep(3000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage, Is.EqualTo(expectedMessage3));

        }
        public static void SentRequestAssert()
        {
            Thread.Sleep(3000);
            string actualMessage = messageBox1.Text;
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage, Is.EqualTo(expectedMessage1));

        }
        public static void CompleteRequestAssert()
        {
            Thread.Sleep(1000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage, Is.EqualTo(expectedMessage2));

        }
    }
}
