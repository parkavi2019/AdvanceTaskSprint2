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
    public class AddDeleteEducation : CommonDriver
    {
#pragma warning disable



        private static IWebElement addNew;
        private static IWebElement addUniversityTextBox;
        private static IWebElement addCountryTextBox;
        private static IWebElement addTitleTextBox;
        private static IWebElement addDegreeTextBox;
        private static IWebElement addYearTextBox;
        private static IWebElement addButton;
        private static IWebElement deleteButton;

        public void renderComponents()
        {
            try
            {
                
                addNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));



                 deleteButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[2]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickAddNewEducation()
        {
            
            renderComponents();

            addNew.Click();
        }
        
        public void renderAddComponents()
        {
            try
            {
                addUniversityTextBox = driver.FindElement(By.Name("instituteName"));
                addCountryTextBox = driver.FindElement(By.Name("country"));
                addTitleTextBox = driver.FindElement(By.Name("title"));
                addDegreeTextBox = driver.FindElement(By.Name("degree"));
                addYearTextBox = driver.FindElement(By.Name("yearOfGraduation"));
                
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
       
        public void addNewEducation(EducationTestModel educationdata)
        {
            
            Thread.Sleep(2000);
          ClickAddNewEducation();
           
            Thread.Sleep(2000);

            
            renderAddComponents();
            addUniversityTextBox.SendKeys(educationdata.University);
            Thread.Sleep(2000);

            addCountryTextBox.Click();
            addCountryTextBox.SendKeys(educationdata.Country);

            addTitleTextBox.Click();
            addTitleTextBox.SendKeys(educationdata.Title);


            addDegreeTextBox.SendKeys(educationdata.Degree);
            addYearTextBox.Click();
            addYearTextBox.SendKeys(educationdata.Year);
            renderAddButton();
            addButton.Click();
            Thread.Sleep(1000);

        }

        public void renderAddButton()
        {
            addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        }

         public void DeleteEducation(EducationTestModel educationdata)
         {
            ClickAddNewEducation();
            Thread.Sleep(2000);
            renderAddComponents();
            renderComponents();
            deleteButton.Click();
          
             Thread.Sleep(1000);


         }
      

    }
}
