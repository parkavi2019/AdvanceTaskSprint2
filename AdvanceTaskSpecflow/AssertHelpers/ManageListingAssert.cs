using AdvanceTaskSpecflow.TestModel;
using AdvanceTaskSpecflow.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskSpecflow.AssertHelpers
{
    public class ManageListingAssert : CommonDriver
    {
        private static IWebElement SkillTitle => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        private static IWebElement messageBox => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        static string expectedMessage1 = "Unable to delete listing. Pending or Accepted skill trade requests exist.";
        static string expectedMessage2 = "Service has been activated";
        static string expectedMessage3 = "Service has been deactivated";
        public static void EditManageListAssert(ManageListTestModel managelist)
        {
            List<ManageListTestModel> EditManageListfile = JsonHelper.ReadTestDataFromJson<ManageListTestModel>("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\JsonFile\\ManageListfile.json");
            Thread.Sleep(2000);
            string actualSkillTitle = SkillTitle.Text;

            string expectedTitle = managelist.Title;

            Assert.That(expectedTitle, Is.EqualTo(actualSkillTitle), "Service Listing Updated successfully.");
            Console.WriteLine("Skill Title: {actualSkillTitle} has been updated sucessfully");
        }
        public static void DeletemanageListAssert()
        {
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage, Is.EqualTo(expectedMessage1));
        }
        public static void toggleEnableAssert()
        {
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage, Is.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3));
        }
        public static void toggleDisableAssert()
        {
            Thread.Sleep(2000);
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);
            Assert.That(actualMessage, Is.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3));
        }

        public static void UpdateManageListAssert(ManageListTestModel managelist)
        {
            List<ManageListTestModel> UpdateManageList = JsonHelper.ReadTestDataFromJson<ManageListTestModel>("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\JsonFile\\UpdateManageList.json");
            Thread.Sleep(2000);
            string actualSkillTitle = SkillTitle.Text;

            string expectedTitle = managelist.Title;

            Assert.That(expectedTitle, Is.EqualTo(actualSkillTitle), "Service Listing Added successfully.");
            Console.WriteLine("Skill Title: {actualSkillTitle} has been added sucessfully");
        }
    }
}
