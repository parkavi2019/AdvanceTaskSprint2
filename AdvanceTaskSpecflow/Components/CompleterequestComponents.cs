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
    public class CompleterequestComponents : CommonDriver
    {
#pragma warning disable
       
        private static IWebElement Receivedrequest1;
        
        private static IWebElement fstcompleteButton;
        
        public void renderReceivedRequest1()
        {
            try
            {
               

                Receivedrequest1 = driver.FindElement(By.XPath("//a[contains(text(),'Received Requests')]"));
             

                
                
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickReceivedRequest1()
        {
            Thread.Sleep(3000);
            renderReceivedRequest1();
            Receivedrequest1.Click();
        }
        public void renderClickComplete()
        {
            try
            {




                //*[@id="received-request-section"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button

                //fstcompleteButton = driver.FindElement(By.XPath("//*[@id=\"sent-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button"));
                 fstcompleteButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[8]/button[1]"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void CompleteRequest()
        {
            
            Thread.Sleep(8000);
            renderClickComplete();
            fstcompleteButton.Click();
        }
    }
}
