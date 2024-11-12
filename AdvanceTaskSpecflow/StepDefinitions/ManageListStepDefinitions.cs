using AdvanceTaskSpecflow.AssertHelpers;
using AdvanceTaskSpecflow.Components;
using AdvanceTaskSpecflow.Step;
using AdvanceTaskSpecflow.TestModel;
using AdvanceTaskSpecflow.Utilities;
using System;
using TechTalk.SpecFlow;

namespace AdvanceTaskSpecflow.StepDefinitions
{
    [Binding]
    public class ManageListStepDefinitions : CommonDriver
    {
        ManageListComponents manageListComponentsObj;
        ManageListStep manageListStepObj;
        UpdateManageListComponents updateManageListComponentsObj;

        public ManageListStepDefinitions()
        {
            manageListComponentsObj = new ManageListComponents();
            manageListStepObj = new ManageListStep();
            updateManageListComponentsObj = new UpdateManageListComponents();
        }
        [Given(@"User Navigate to the ManageListingsTab")]
        public void GivenUserNavigateToTheManageListingsTab()
        {
            manageListComponentsObj.renderClickManageList();
            LogScreenshot("ClickManagelist");
        }
        [Then(@"user able edit list'([^']*)' successfully")]
        public void ThenUserAbleEditListSuccessfully(string ManageListPath)
        {
            manageListComponentsObj.renderClickManageList();
            manageListStepObj.EditManageList();
            LogScreenshot("EditList");
        }

       
        [Given(@"User navigate to the ManageListingsTab")]
        public void GivenUsernavigateToTheManageListingsTab()
        {
            manageListComponentsObj.renderClickManageList();
        }

        [Then(@"user able to view the profile list")]
        public void ThenUserAbleToViewTheProfileList()
        {
            manageListComponentsObj.renderClickManageList();
            manageListStepObj.viewManageList();
            LogScreenshot("ViewList");
        }
        [Given(@"User Navigate to the manageListingsTab")]
        public void GivenUserNavigateToThemanageListingsTab()
        {
            manageListComponentsObj.renderClickManageList();
        }

        [Then(@"user able to delete the list")]
        public void ThenUserAbleToDeleteTheList()
        {
            manageListComponentsObj.renderClickManageList();
            manageListStepObj.deletemanagelist();
            LogScreenshot("DeleteList");
        }
        [Given(@"User navigate to the ManagelistingsTab")]
        public void GivenUserNavigateToTheManagelistingsTab()
        {
            manageListComponentsObj.renderClickManageList();
        }
        [Then(@"user able to click toggle checkbox enable")]
        public void ThenUserAbleToClickToggleCheckboxEnable()
        {
            manageListComponentsObj.renderClickManageList();
            manageListStepObj.toggeleEnableManageList();
            LogScreenshot("ToggeleList");
        }
        [Given(@"user able to enter to the manageListingtab")]
        public void GivenUserAbleToEnterToTheManageListingtab()
        {
            manageListComponentsObj.renderClickManageList();
        }

        [Then(@"user able to click toggle checkbox disable")]
        public void ThenUserAbleToClickToggleCheckboxDisable()
        {
            manageListComponentsObj.renderClickManageList();
            manageListStepObj.toggeledisableManageList();
            LogScreenshot("ToggeledisableList");
        }


        [Given(@"user Navigate to the ManageListingsTab")]
        public void GivenuserNavigateToTheManageListingsTab()
        {
            manageListComponentsObj.renderClickManageList();
        }

        [Then(@"user able to update '([^']*)' successfully")]
        public void ThenUserAbleToUpdateSuccessfully(string manageListPath)
        {
            // manageListComponentsObj.renderClickManageList();
            updateManageListComponentsObj.renderShareskill();
             manageListStepObj.UpdatemanageList();
            LogScreenshot("UpdateList");


        }



    }
}
