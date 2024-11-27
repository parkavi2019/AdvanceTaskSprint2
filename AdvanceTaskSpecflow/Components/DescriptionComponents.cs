using AdvanceTaskSpecflow.TestModel;
using AdvanceTaskSpecflow.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskSpecflow.Components
{
    public class DescriptionComponents : CommonDriver
    {
#pragma warning disable
        private static IWebElement descriptionEditButton;
        private static IWebElement descriptionTextBox;
        private static IWebElement saveButton;
        public void renderClickDescription()
        {
            try
            {
                descriptionEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
      
        public void renderAddComponents()
        {
            try
            {
                descriptionTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void rendersaveButton()
        {
            try
            {
                saveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void addDescription(DescriptionTestModel descriptiondata)
        {
            Thread.Sleep(3000);
            renderClickDescription();
            descriptionEditButton.Click();
            
            renderAddComponents();
           descriptionTextBox.Clear();
            
            descriptionTextBox.SendKeys(descriptiondata.Description);
            Thread.Sleep(3000);
            rendersaveButton();
            saveButton.Click();
        }


    }
}
