using AdvanceTaskSpecflow.AssertHelpers;
using AdvanceTaskSpecflow.Components;
using AdvanceTaskSpecflow.TestModel;
using AdvanceTaskSpecflow.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskSpecflow.Step
{
    public class ManageListStep : CommonDriver
    {
        ManageListComponents manageListComponentsObj;
        ManageListingAssert manageListingAssertObj;
        UpdateManageListComponents updateManageListComponentsObj;
        public ManageListStep()
        {
            manageListComponentsObj = new ManageListComponents();
            manageListingAssertObj = new ManageListingAssert();
            updateManageListComponentsObj = new UpdateManageListComponents();
        }
        public void EditManageList()
        {
            List<ManageListTestModel> EditManageListfile = JsonHelper.ReadTestDataFromJson<ManageListTestModel>("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\JsonFile\\ManageListfile.json");
            foreach (ManageListTestModel model in EditManageListfile)
            {
                manageListComponentsObj.renderClickManageList();
                manageListComponentsObj.EditManageList(model);
                ManageListingAssert.EditManageListAssert(model);


            }
        }
        public void viewManageList()
        {
            manageListComponentsObj.renderClickManageList();
            manageListComponentsObj.ViewManageList();
        }
        public void deletemanagelist()
        {
            manageListComponentsObj.renderClickManageList();
            manageListComponentsObj.DeleteManageList();
            ManageListingAssert.DeletemanageListAssert();
        }
        public void toggeleEnableManageList()
        {
            manageListComponentsObj.renderClickManageList();
            manageListComponentsObj.ToggleEnable();
            ManageListingAssert.toggleEnableAssert();
        }
        public void toggeledisableManageList()
        {
            manageListComponentsObj.renderClickManageList();
            manageListComponentsObj.ToggleDisable();
            ManageListingAssert.toggleDisableAssert();
        }

        public void UpdatemanageList()
        {

            List<ManageListTestModel> UpdateManageList = JsonHelper.ReadTestDataFromJson<ManageListTestModel>("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\JsonFile\\UpdateManageList.json");
            foreach (ManageListTestModel model in UpdateManageList)
            {
                // manageListComponentsObj.renderClickManageList();
                // manageListComponentsObj.updateManageList(model);
                updateManageListComponentsObj.renderShareskill();
               updateManageListComponentsObj.updateManageList(model);
                ManageListingAssert.UpdateManageListAssert(model);

            }
            

        }
    }
}
