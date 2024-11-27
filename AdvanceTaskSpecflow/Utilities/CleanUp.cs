using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskSpecflow.Utilities
{
    public class CleanUp : CommonDriver
    {
        public void ClearEducationExistingdata()
        {
            try
            {
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
                var deleteButtons = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
                foreach (var button in deleteButtons)
                {
                   
                    button.Click();
                    Thread.Sleep(2000);
                }

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("no items to delete");
            }

        }
        public void clearCertificationExistingdata()
        {
            try
            {
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
                var deleteButtons = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
                foreach (var button in deleteButtons)
                {
                    button.Click();
                    Thread.Sleep(2000);
                }

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("no items to delete");
            }

        }
       /* public void clearDescriptionExistingdata()
        {
            try
            {
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
                var deleteButtons = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
                foreach (var button in deleteButtons)
                {
                    button.Click();
                    Thread.Sleep(2000);
                }

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("no items to delete");
            }

        }*/
    }
}
