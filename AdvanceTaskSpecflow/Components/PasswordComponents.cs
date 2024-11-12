using AdvanceTaskSpecflow.TestModel;
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
    public class PasswordComponents : CommonDriver
    {
#pragma warning disable
        ProfileTabComponents profileTabComponentsObj;
        private static IWebElement selectchangePassword;
    
        private static IWebElement currentPasswordTextbox;
        private static IWebElement newPasswordTextbox;
        private static IWebElement confirmPasswordTextbox;
        private static IWebElement userNameDropdown;
        private static IWebElement savebutton;



        public PasswordComponents()
        {
            profileTabComponentsObj = new ProfileTabComponents();
        }
        public void renderUserName()
        {
            try
            {
                //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                //userNameDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span")));
               userNameDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
                // userNameDropdown = driver.FindElement(By.XPath(" //*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/text()[2]"));
               // userNameDropdown = driver.FindElement(By.LinkText("Manjuparkavi"));
                
            }
            catch (StaleElementReferenceException st)
            {
                userNameDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
                userNameDropdown.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderChangePassword()
        {
            try
            {
               selectchangePassword = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]"));
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
      
        public void  renderaddPassword()
        {
            try
            {
                currentPasswordTextbox = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[1]/input"));
                newPasswordTextbox = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[2]/input"));
                confirmPasswordTextbox = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[3]/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSavebutton()
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
       
        public void addPassword(PasswordTestModel passworddata)
        {
            Thread.Sleep(2000);
            renderUserName();
            userNameDropdown.Click();
           
            Thread.Sleep(3000);
            renderChangePassword();
           
            selectchangePassword.Click();

            renderaddPassword();
            currentPasswordTextbox.Click();
            currentPasswordTextbox.SendKeys(passworddata.CurrentPassword);

            newPasswordTextbox.Click();
            newPasswordTextbox.SendKeys(passworddata.NewPassword);

            confirmPasswordTextbox.Click();
            confirmPasswordTextbox.SendKeys(passworddata.ConfirmPassword);
            Thread.Sleep(3000);

            //profileTabComponentsObj.ClickSavebutton();
            renderSavebutton();
            savebutton.Click();
            Thread.Sleep(1000);


        }

    }
   

}
