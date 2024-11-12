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
    public class AddDeleteCertification : CommonDriver
    {
#pragma warning disable
        private static IWebElement addNew;
        private static IWebElement certificateTextBox;
        private static IWebElement certifiedFromTextBox;
        private static IWebElement yearTextBox;
        private static IWebElement addButton;
        private static IWebElement deleteButton;

        public void renderComponents()
        {
            try
            {

                addNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));



                deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickAddNewCertification()
        {
            // Thread.Sleep(1000);
            renderComponents();

            addNew.Click();
        }
        public void renderAddComponents()
        {
            try
            {
                certificateTextBox = driver.FindElement(By.Name("certificationName"));
                certifiedFromTextBox = driver.FindElement(By.Name("certificationFrom"));
                
                yearTextBox = driver.FindElement(By.Name("certificationYear"));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAddButton()
        {
            try
            {
                addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void addNewCertification(CertificationTestModel certificationdata)
        {
            Thread.Sleep(2000);
            ClickAddNewCertification();
            renderAddComponents();
            certificateTextBox.Click();
            certificateTextBox.SendKeys(certificationdata.Certificate);
            certifiedFromTextBox.Click();
            certifiedFromTextBox.SendKeys(certificationdata.CertifiedFrom);
            yearTextBox.Click();
            yearTextBox.SendKeys(certificationdata.Year);

            renderAddButton();
            addButton.Click();
            Thread.Sleep(1000);
        }
        public void DeleteCertification(CertificationTestModel certificationdata)
        {
            ClickAddNewCertification();
            Thread.Sleep(2000);
            renderAddComponents();
            renderComponents();
            deleteButton.Click();

            Thread.Sleep(1000);


        }

    }
}
