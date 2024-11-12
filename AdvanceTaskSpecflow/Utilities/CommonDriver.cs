using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceTaskSpecflow.Components;
using AventStack.ExtentReports.Core;
using AdvanceTaskSpecflow.Pages;
using OpenQA.Selenium.Support.Extensions;
using TechTalk.SpecFlow;
using AventStack.ExtentReports.Gherkin.Model;


namespace AdvanceTaskSpecflow.Utilities
{
    public class CommonDriver
    {

#pragma warning disable
        public static IWebDriver driver;
        
        public static ProfileTabComponents profileTabComponentsObj;

        SigninPage signinPageObj;
        LoginPage loginPageObj;
        CleanUp cleanUpObj;
       
          private static ExtentReports extent;
        private static ExtentTest testreport;
       
        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();

            //Maximize the window
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            signinPageObj = new SigninPage();
            loginPageObj = new LoginPage();
            signinPageObj.ClickSignIn();
            loginPageObj.LoginSteps();

          //   CleanUpdata();
            

        }
        public void LogScreenshot(string ScreenshotName)
        {
            string screenshotPath = addScreenshot(ScreenshotName);
            if (testreport != null)
            {
                testreport.Log(Status.Info, "Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            }
        }

        public static string addScreenshot(string screenshotName)
        {
             ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
              Screenshot screenshot = takesScreenshot.GetScreenshot();
           // var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            string screenshotPath = $"Screenshots/{screenshotName}_{DateTime.Now:yyyyMMddHHmmss}.png";
            string screenshotLocation = Path.Combine("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\", screenshotPath);

            screenshot.SaveAsFile(screenshotLocation, OpenQA.Selenium.ScreenshotImageFormat.Png);
            return screenshotLocation;



        }
       
        [TearDown]
        public void TearDownAction()
        {
            driver.Quit();
        }
        


        public void CleanUpdata()
        {
           
            profileTabComponentsObj = new ProfileTabComponents();
            cleanUpObj = new CleanUp();
            profileTabComponentsObj.cilckEducationTab();
            cleanUpObj.ClearEducationExistingdata();

            profileTabComponentsObj.cilckCertificationTab();
            cleanUpObj.clearCertificationExistingdata();




        }
       
        public void Close()
        {
           
            driver.Quit();
           
        }
      

    }
}
