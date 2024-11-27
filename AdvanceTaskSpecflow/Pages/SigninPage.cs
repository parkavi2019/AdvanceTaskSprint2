using AdvanceTaskSpecflow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskSpecflow.Pages
{
    public class SigninPage : CommonDriver
    {
#pragma warning disable
        private static IWebElement signInButton;
        public void renderAddComponent()
        {
            try
            {
                signInButton = driver.FindElement(By.XPath("//a[text()='Sign In']"));
               // signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));

            }
            catch (StaleElementReferenceException st)
            {
                signInButton = driver.FindElement(By.XPath("//a[text()='Sign In']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickSignIn()
        {
           
            renderAddComponent();
            signInButton.Click();
            Thread.Sleep(2000);
        }
    }
}
