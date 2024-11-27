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
    public class UpdateManageListComponents : CommonDriver
    {
#pragma warning disable
        private static IWebElement shareSkillButton;
        private static IWebElement titleTextBox1;
        private static IWebElement descriptionTextBox1;
        private static IWebElement categoryBox1;
        private static IWebElement subcategoryBox1;
        private static IWebElement tagsBox;
        private static IWebElement availableStartday;
        private static IWebElement availableEndday;
        private static IWebElement skillexchangeBox;

        private static IReadOnlyList<IWebElement> serviceType;
        private static IReadOnlyList<IWebElement> locationType;
        private static IReadOnlyList<IWebElement> skillTrade;
        private static IReadOnlyList<IWebElement> active;

        string serviceHourly = "Hourly basis service";
        string serviceOneoff = "One-off service";
        string locationOnsite = "On-site";
        string locationOnline = "Online";
        string skillExchange = "Skill-exchange";
        string skillCredit = "Credit";
        string activeBox = "active";
        string activeHidden = "Hidden";
        private static IWebElement saveButton1;
       
        public void renderShareskill()
        {
            try
            {
                shareSkillButton = driver.FindElement(By.XPath("//a[contains(text(),'Share Skill')]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderTiltle()
        {
            try
            {
               // titleTextBox1 = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
                titleTextBox1 = driver.FindElement(By.Name("title"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDescription()
        {
            try
            {
                //descriptionTextBox1 = driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[2]/div[1]/div[2]/div[1]/textarea[1]"));
                descriptionTextBox1 = driver.FindElement(By.Name("description"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderCategory1()
        {
            try
            {
                //categoryBox1 = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select"));
                categoryBox1 = driver.FindElement(By.Name("categoryId"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSubcategory1()
        {
            try
            {
               // subcategoryBox1 = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
                subcategoryBox1 = driver.FindElement(By.Name("subcategoryId"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderTags()
        {
            try
            {
                tagsBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderServiceType()
        {
            try
            {

                serviceType = driver.FindElements(By.Name("serviceType"));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderLocationType()
        {
            try
            {
                locationType = driver.FindElements(By.Name("locationType"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
       public void renderAvailableStartdays()
        {
            try
            {
                availableStartday = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAvailableEnddays()
        {
            try
            {
                availableEndday = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSkilltrade()
        {
            try
            {
                skillTrade = driver.FindElements(By.Name("skillTrades"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSkillExchange()
        {
            try
            {
                skillexchangeBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderActive()
        {
            try
            {
                active = driver.FindElements(By.Name("isActive"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSaveButton1()
        {
            try
            {
                saveButton1 = driver.FindElement(By.XPath("//input[@value='Save']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void updateManageList(ManageListTestModel managelist)

        {
            renderShareskill();
            shareSkillButton.Click();
            Thread.Sleep(1000);
            renderTiltle();

            titleTextBox1.SendKeys(managelist.Title);
            Thread.Sleep(1000);


            renderDescription();
            descriptionTextBox1.SendKeys(managelist.Description);


            renderCategory1();
           // categoryBox1.Click();
            categoryBox1.SendKeys(managelist.Category);
            Thread.Sleep(2000);

            renderSubcategory1();

            subcategoryBox1.Click();
            subcategoryBox1.SendKeys(managelist.Subcategory);

            Thread.Sleep(2000);

            renderTags();
           tagsBox.SendKeys(managelist.Tags);
            tagsBox.SendKeys("\n");


            renderServiceType();

            if (managelist.ServiceType == serviceHourly)
            {
                serviceType.ElementAt(0).Click();
            }
            else
            {
                serviceType.ElementAt(1).Click();
            }


            renderLocationType();
            if (managelist.LocationType == locationOnline)
            {
                locationType.ElementAt(0).Click();
            }
            else
            {
                locationType.ElementAt(1).Click();
            }

              renderAvailableStartdays();
              availableStartday.Click();
              availableStartday.SendKeys(managelist.Startdate);
              Thread.Sleep(1000);

              renderAvailableEnddays();
              availableEndday.Click();
              availableEndday.SendKeys(managelist.Enddate);

  
            Thread.Sleep(2000);
            renderSkilltrade();
            if (managelist.SkillTrade == skillExchange)
            {
                skillTrade.ElementAt(0).Click();

            }
            else
            {
                skillTrade.ElementAt(1).Click();
            }
            renderSkillExchange();
           skillexchangeBox.SendKeys(managelist.SkillExchange);
           skillexchangeBox.SendKeys("\n");

            Thread.Sleep(2000);
            renderActive();
            if (managelist.Active == activeBox)
            {
                active.ElementAt(0).Click();
            }
            else
            {
                active.ElementAt(1).Click();
            }
            renderSaveButton1();
            saveButton1.Click();
            Thread.Sleep(1000);
        }
    }
}
