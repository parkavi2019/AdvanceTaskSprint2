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
    public class CertificationStepDefinitions : CommonDriver
    {
        ProfileTabComponents profileTabComponentsObj;
        AddDeleteCertification addDeleteCertificationObj;
        CertificationStep certificationStepObj;

        public CertificationStepDefinitions()
        {
            profileTabComponentsObj = new ProfileTabComponents();
            addDeleteCertificationObj = new AddDeleteCertification();
             certificationStepObj = new CertificationStep();
        }

        [Given(@"User Navigate to the CertificationTab")]
        public void GivenUserNavigateToTheCertificationTab()
        {
            profileTabComponentsObj.cilckCertificationTab();
            LogScreenshot("ClickCertification");
        }
        [Then(@"Create a add Certification '([^']*)' into user profile successfully")]
        public void ThenCreateAAddCertificationIntoUserProfileSuccessfully(string CertificationPath)
        {
            profileTabComponentsObj.cilckCertificationTab();
            certificationStepObj.AddCertificationData();
            LogScreenshot("AddCertification");

        }

       
        [Given(@"User Navigate to the Certificationtab")]
        public void GivenUserNavigateToTheCertificationtab()
        {
            profileTabComponentsObj.cilckCertificationTab();
        }
        [Then(@"User able to Delted'([^']*)' Certification successfully")]
        public void ThenUserAbleToDeltedCertificationSuccessfully(string CertificationPath)
        {
            profileTabComponentsObj.cilckCertificationTab();
            certificationStepObj.AddCertificationData();
            certificationStepObj.DeleteCertificationData();
            LogScreenshot("DeleteCertification");

        }

    }
}
