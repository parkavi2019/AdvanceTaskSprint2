using AdvanceTaskSpecflow.AssertHelpers;
using AdvanceTaskSpecflow.Components;
using AdvanceTaskSpecflow.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskSpecflow.Step
{
    public class ManageRequestStep : CommonDriver
    {
        
        ManageRequestComponents manageRequestComponentsObj;
        ManageRequestAssert manageRequestAssertObj;
        CompleterequestComponents completerequestComponentsObj;
         
        public ManageRequestStep()
        {
            
            manageRequestComponentsObj = new ManageRequestComponents();
            completerequestComponentsObj = new CompleterequestComponents();
            manageRequestAssertObj = new ManageRequestAssert();
        }
        public void ClickOnManageRequest()
        {
            manageRequestComponentsObj.clickmanageRequest();
        }

        public void ReceviedList()
        {
            manageRequestComponentsObj.ClickReceivedRequest();
            manageRequestComponentsObj.ReceivedRequestList();
           
            ManageRequestAssert.RecivedRequestAssert();
        }
        public void SentRequests()
        {

            manageRequestComponentsObj.ClickSentRequest();
            manageRequestComponentsObj.SentRequestList();
            ManageRequestAssert.SentRequestAssert();
        }
        public void completeRequests()
        {

            completerequestComponentsObj.ClickReceivedRequest1();
            completerequestComponentsObj.CompleteRequest();
           
            ManageRequestAssert.CompleteRequestAssert();
        }
    }
}
