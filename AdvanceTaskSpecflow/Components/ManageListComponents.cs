using AdvanceTaskSpecflow.TestModel;
using AdvanceTaskSpecflow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskSpecflow.Components
{
    public class ManageListComponents : CommonDriver
    {
#pragma warning disable
        private static IWebElement managelistingTab;
        private static IWebElement editButton;
        private static IWebElement titleTextBox;
        private static IWebElement categoryBox;
        private static IWebElement subcategoryBox;
        private static IWebElement saveButton;
        private static IWebElement eyeIcon;
        private static IWebElement crossIcon;
        private static IWebElement yesIcon;
        private static IWebElement activeCheckBox;
     
        public void renderClickManageList()
        {
            try
            {
                 managelistingTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]"));
                // managelistingTab = driver.FindElement(By.LinkText("Manage Listings"));
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderClickEditButton()
        {
            try
            {

                editButton = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderTitle()
        {
            try
            {
                titleTextBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        public void renderCategory()
        {
            try
            {

                categoryBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSubcategory()
        {
            try
            {

                subcategoryBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSaveButton()
        {
            try
            {
                saveButton = driver.FindElement(By.XPath("//input[@value='Save']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderclickView()
        {
            eyeIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[1]/i"));

        }
        public void renderClickCrossicon()
        {
            crossIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));

        }
        public void renderClickYes()
        {
            yesIcon = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
        }
        public void renderClickActive()
        {
            activeCheckBox = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div/input"));
           // activeCheckBox = driver.FindElement(By.Name("isActive"));
        }
      

        public void EditManageList(ManageListTestModel managelist)
        {
            // Thread.Sleep(2000);
            renderClickManageList();
            managelistingTab.Click();
            Thread.Sleep(3000);
            renderClickEditButton();
            editButton.Click();
            Thread.Sleep(2000);
            renderTitle();
            titleTextBox.Clear();
            titleTextBox.SendKeys(managelist.Title);
            Thread.Sleep(1000);
            renderCategory();
            categoryBox.SendKeys(managelist.Category);
            renderSubcategory();
            subcategoryBox.SendKeys(managelist.Subcategory);
            renderSaveButton();
            saveButton.Click();
            Thread.Sleep(1000);

        }
        public void ViewManageList()
        {
            Thread.Sleep(1000);
            renderClickManageList();
            managelistingTab.Click();
            Thread.Sleep(3000);
            renderclickView();
            eyeIcon.Click();
            Thread.Sleep(3000);
        }
        public void DeleteManageList()
        {
            Thread.Sleep(1000);
            renderClickManageList();
            managelistingTab.Click();
            Thread.Sleep(3000);
            renderClickCrossicon();
            crossIcon.Click();
            Thread.Sleep(2000);
            renderClickYes();
            yesIcon.Click();

        }
        public void ToggleEnable()
        {
            Thread.Sleep(1000);
            renderClickManageList();
            managelistingTab.Click();
            Thread.Sleep(2000);
            renderClickActive();
            activeCheckBox.Click();
            

        }
        public void ToggleDisable()
        {
            Thread.Sleep(1000);
            renderClickManageList();
            managelistingTab.Click();
            Thread.Sleep(2000);
            renderClickActive();
            activeCheckBox.Click();


        }

    }   
}
