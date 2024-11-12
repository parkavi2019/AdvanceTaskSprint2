using AdvanceTaskSpecflow.AssertHelpers;
using AdvanceTaskSpecflow.Components;
using AdvanceTaskSpecflow.TestModel;
using AdvanceTaskSpecflow.Utilities;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskSpecflow.Step
{
    public class EducationStep : CommonDriver
    {
        ProfileTabComponents profileTabComponentObj;
        AddDeleteEducation addDeleteEducationObj;
        EducationAssert educationAssertObj;

        public EducationStep()
        {
            profileTabComponentObj = new ProfileTabComponents();
            addDeleteEducationObj = new AddDeleteEducation();
            educationAssertObj = new EducationAssert();
        }

        public void AddEducationData()
        {
            List<EducationTestModel> AddEducationfile = JsonHelper.ReadTestDataFromJson<EducationTestModel>("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\JsonFile\\AddEducationfile.json");

            foreach (EducationTestModel model in AddEducationfile)
            {

                profileTabComponentObj.cilckEducationTab();
                addDeleteEducationObj.addNewEducation(model);
                EducationAssert.AddEducationAssert();
            }
        }
        public void DeleteEducationData()
        {
            List<EducationTestModel> DeleteEducationfile = JsonHelper.ReadTestDataFromJson<EducationTestModel>("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\JsonFile\\DeleteEducationfile.json");
            foreach (EducationTestModel model in DeleteEducationfile)
            {
                profileTabComponentObj.cilckEducationTab();
                addDeleteEducationObj.addNewEducation(model);
                addDeleteEducationObj.DeleteEducation(model);
                EducationAssert.DeleteEducationAssert();

            }

        }
    }
}
