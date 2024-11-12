using AdvanceTaskSpecflow.AssertHelpers;
using AdvanceTaskSpecflow.Components;
using AdvanceTaskSpecflow.TestModel;
using AdvanceTaskSpecflow.Utilities;
using Microsoft.AspNetCore.Http.Features.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskSpecflow.Step
{
     public class DescriptionStep : CommonDriver
    {
    DescriptionComponents descriptionComponentsObj;
        DescriptionAssert descriptionAssertObj;

        public DescriptionStep()
        {
            descriptionComponentsObj = new DescriptionComponents();
            descriptionAssertObj = new DescriptionAssert();
        }

        public void DescriptionData()
        {
            List<DescriptionTestModel> Description = JsonHelper.ReadTestDataFromJson<DescriptionTestModel>("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\JsonFile\\Description.json");
            foreach (DescriptionTestModel model in Description)
            {
                descriptionComponentsObj.renderClickDescription();
                
                descriptionComponentsObj.addDescription(model);
                LogScreenshot("addDescription");
                DescriptionAssert.AddDescriptionAssert();
            }
        }
    }
}
