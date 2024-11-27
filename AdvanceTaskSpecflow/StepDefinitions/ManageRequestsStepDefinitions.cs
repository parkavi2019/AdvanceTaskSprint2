using AdvanceTaskSpecflow.Components;
using AdvanceTaskSpecflow.Step;
using AdvanceTaskSpecflow.Utilities;
using System;
using TechTalk.SpecFlow;

namespace AdvanceTaskSpecflow.StepDefinitions
{
    [Binding]
    public class ManageRequestsStepDefinitions : CommonDriver
    {
        
       
        ManageRequestStep manageRequestStepObj;
        
        public ManageRequestsStepDefinitions()
        {
           
           
            manageRequestStepObj = new ManageRequestStep();
        }

        [Given(@"User Navigate to Managerequest Dropdown")]
        public void GivenUserNavigateToManagerequestDropdown()
        {


            manageRequestStepObj.ClickOnManageRequest();
           
        }
       

        [Then(@"user able to accept receivedrequest")]
        public void ThenUserAbleToAcceptReceivedrequest()
        {

            manageRequestStepObj.ReceviedList();
            
            LogScreenshot("RecevieList");
        }


        
       [Given(@"user able to click managerequest dropdown")]
        public void GivenUserAbleToClickManagerequestDropdown()
        {
            manageRequestStepObj.ClickOnManageRequest();
        }

        [Then(@"User able to send requests")]
        public void ThenUserAbleToSendRequests()
        {
           
            manageRequestStepObj.SentRequests();
            LogScreenshot("SentRequest");
        }
        [Given(@"user naviagate to managerequest dropdown")]
        public void GivenUserNaviagateToManagerequestDropdown()
        {
            manageRequestStepObj.ClickOnManageRequest();
        }



        [Then(@"user able to complete the requests list")]
        public void ThenUserAbleToCompleteTheRequestsList()
        {
            /*manageRequestStepObj.ReceviedList();*/
           
            manageRequestStepObj.completeRequests();
            LogScreenshot("CompleteRequest");
        }


    }
}
