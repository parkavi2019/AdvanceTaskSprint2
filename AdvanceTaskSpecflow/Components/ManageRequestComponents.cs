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
    public class ManageRequestComponents : CommonDriver
    {
#pragma warning disable
        private static IWebElement manageRequest;
        private static IWebElement Receivedrequest;
        private static IWebElement Sentrequest;
      
        private static IWebElement fstCategory;
        private static IWebElement fstTitle;
        
         private static IWebElement completeRequest;
        public void renderClickManageRequest()
        {
            try
            {

                 manageRequest = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]"));
               
               //  manageRequest = driver.FindElement(By.XPath("//*[@id='received-request-section']/section[1]/div/div[1]/text()"));
                //  manageRequest = driver.FindElement(By.LinkText("Manage Requests"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clickmanageRequest()
        {
            Thread.Sleep(3000);
            renderClickManageRequest();
            manageRequest.Click();
        }
        

        public void renderClickReceivedRequest()
        {
            try
            {

                
                //Receivedrequest = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]"));
                Receivedrequest = driver.FindElement(By.XPath("//a[contains(text(),'Received Requests')]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickReceivedRequest()
        {
            Thread.Sleep(2000);
            renderClickReceivedRequest();
            Receivedrequest.Click();
        }

        public void renderClickCategory()
        {
            try
            {


                fstCategory = driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[1]"));
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

       
        public void renderClickSentRequest()
        {
            try
            {


                Sentrequest = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[2]"));
               // selectSentrequest = driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/section[1]/div/div[1]/div/a[2]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickSentRequest()
        {
            Thread.Sleep(2000);
            renderClickSentRequest();
            Sentrequest.Click();
        }
        public void renderClickTitle()
        {
            try
            {


                fstTitle = driver.FindElement(By.XPath("//*[@id=\"sent-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[2]/a"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


      /*  public void renderClickComplete()
         {
             try
             {



                completeRequest = driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button"));
                

             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex);
             }
         }*/
       /* public void CompleteRequest()
        {
            Thread.Sleep(2000);
            renderClickComplete();
            completeRequest.Click();
        }*/
        public void ReceivedRequestList()
        {
            Thread.Sleep(7000);
           
            
           renderClickCategory();
            fstCategory.Click();
         
        }
        public void SentRequestList()
        {
            Thread.Sleep(2000);
            renderClickTitle();
            fstTitle.Click();
        }
       /* public void CompleteRequest()
        {
           // Thread.Sleep(3000);

            renderClickManageRequest();
            manageRequestDropdown.Click();
            Thread.Sleep(3000);
             renderClickReceivedRequest();
            selectReceivedrequest.Click();
            //renderClickSentRequest();
            
           // selectSentrequest.Click();

           // Thread.Sleep(3000);
            renderClickComplete();
          manageRequestDropdown1.Click();
            Thread.Sleep(2000);
            selectSentrequest1.Click();
            Thread.Sleep(3000);
            clickcompleteButton.Click();
        }*/

    }
}
