using AdvanceTaskSpecflow.Pages;
using AdvanceTaskSpecflow.TestModel;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using BoDi;

namespace AdvanceTaskSpecflow.Utilities
{

    [Binding]
    public class Hooks : CommonDriver
    {
#pragma warning disable
     

        public static IWebDriver driver;
        public static ExtentReports extent;
        private ExtentTest test;
        
        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\ExtentReports\\");

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);




        }





        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            Initialize();
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
          
           
        }
       
        [AfterScenario]
        public void AfterSCenario()
        {

            Close();
            
        }
       /* [AfterScenario]
        public string addScreenshot(string screenshotName)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotPath = $"Screenshots/{screenshotName}_{DateTime.Now:yyyyMMddHHmmss}.png";
            string screenshotLocation = Path.Combine("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\Screenshots\\", screenshotPath);

            screenshot.SaveAsFile(screenshotLocation, OpenQA.Selenium.ScreenshotImageFormat.Png);
            return screenshotLocation;



        }
*/

        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();

        }
       /* [AfterScenario]
        public void LogScreenshot(string ScreenshotName)
        {
            string screenshotPath = addScreenshot(ScreenshotName);
            if (test != null)
            {
                test.Log(Status.Info, "Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            }
        }*/



    }
}
