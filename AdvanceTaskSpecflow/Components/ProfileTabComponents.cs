using AdvanceTaskSpecflow.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskSpecflow.Components
{
    public class ProfileTabComponents : CommonDriver
    {
#pragma warning disable
        private static IWebElement userNameDropdown;
        private static IWebElement savebutton;
        private static IWebElement educationTab;
        private static IWebElement certificationTab;
        private static IWebElement descriptionEditButton;
        private static IWebElement manageRequestDropdown;
       /* public void renderUserName()
        {
            try
            {
                //userNameDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
               // userNameDropdown = driver.FindElement(By.XPath(" //*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/text()[2]"));
                userNameDropdown = driver.FindElement(By.LinkText("Manjuparkavi"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }*/
       /* public void ClickUserName()
        {
            renderUserName();
            Thread.Sleep(1000);
            userNameDropdown.Click();
            
        }*/
       /* public void renderSavebutton()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                savebutton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button")));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickSavebutton()
        {
            renderSavebutton();
            
            savebutton.Click();
            Thread.Sleep(1000);
        }*/
        public void renderEducation()
        {
            try
            {
               
                 educationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void cilckEducationTab()
        {
            Thread.Sleep(2000);
            renderEducation();
           
            educationTab.Click();
        }
        public void renderCertification()
        {
            try
            {

                certificationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void cilckCertificationTab()
        {
            Thread.Sleep(2000);
            renderCertification();

            certificationTab.Click();
        }
       /* public void renderManageRequest()
        {
            try
            {

                 manageRequestDropdown = driver.FindElement(By.LinkText("Manage Requests"));
                // manageRequestDropdown = driver.FindElement(By.XPath("//*[@id='received-request-section']/section[1]/div/div[1]"));  

               // manageRequestDropdown = driver.FindElement(By.XPath("//*[@id='received - request - section']/section[1]/div/div[1]/text()"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickManageRequest()
        {
            Thread.Sleep(1000);
            renderManageRequest();
            manageRequestDropdown.Click();
        }*/

    }
   
}
