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
    public class DescriptionStepDefinitions : CommonDriver
    {
       
        DescriptionComponents descriptionComponentsObj;
        DescriptionAssert descriptionAssertObj;
        DescriptionStep descriptionStepObj;
        public DescriptionStepDefinitions()
        {
            
            descriptionComponentsObj = new DescriptionComponents();

            descriptionStepObj = new DescriptionStep();


        }
        [Given(@"User able to click description edit button")]
        public void GivenUserAbleToClickDescriptionEditButton()
        {
            descriptionComponentsObj.renderClickDescription();
          //  LogScreenshot("renderClickDescription");
        }
        [Then(@"User able write their '([^']*)' description sentences")]
        public void ThenUserAbleWriteTheirDescriptionSentences(string DescriptionPath)
        {
            descriptionComponentsObj.renderClickDescription();
            LogScreenshot("addDescription");
            descriptionStepObj.DescriptionData();
        }

        
    }
}
