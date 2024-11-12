using AdvanceTaskSpecflow.AssertHelpers;
using AdvanceTaskSpecflow.Components;
using AdvanceTaskSpecflow.Pages;
using AdvanceTaskSpecflow.Step;
using AdvanceTaskSpecflow.TestModel;
using AdvanceTaskSpecflow.Utilities;
using System;
using TechTalk.SpecFlow;

namespace AdvanceTaskSpecflow.StepDefinitions
{
    [Binding]
    public class EducationStepDefinitions : CommonDriver
    {
#pragma warning disable
        ProfileTabComponents profileTabComponentsObj;
        AddDeleteEducation addDeleteEducationObj;
        EducationStep educationStepObj;
       
       


        public EducationStepDefinitions()
        {
            profileTabComponentsObj = new ProfileTabComponents();
            addDeleteEducationObj = new AddDeleteEducation();
            educationStepObj = new EducationStep();
         
          
            
           



        }
        [Given(@"User navigate to the EducationTab")]
        public void GivenUserNavigateToTheEducationTab()
        {
            profileTabComponentsObj.cilckEducationTab();
            LogScreenshot("CilckEducation");
        }
        [Then(@"Create a add Education '([^']*)' into user profile successfully")]
        public void ThenCreateAAddEducationIntoUserProfileSuccessfully(string educationPath)
        {
            profileTabComponentsObj.cilckEducationTab();
            educationStepObj.AddEducationData();
            LogScreenshot("Addeducation");
        }


        [Given(@"User navigate to the Educationtab")]
        public void GivenUserNavigateToTheEducationtab()
        {
            profileTabComponentsObj.cilckEducationTab();
        }
        [Then(@"User able to deleted '([^']*)' education successfully")]
        public void ThenUserAbleToDeletedEducationSuccessfully(string educationPath)
        {
            profileTabComponentsObj.cilckEducationTab();
            educationStepObj.AddEducationData();
            educationStepObj.DeleteEducationData();
            LogScreenshot("DeleteEducation");

        }


        





    }
}
