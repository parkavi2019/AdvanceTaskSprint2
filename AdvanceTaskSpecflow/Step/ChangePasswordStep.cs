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
    public class ChangePasswordStep : CommonDriver
    {
        ProfileTabComponents profileTabComponentsObj;
        PasswordComponents passwordComponentsObj;
        PasswordAssert passwordAssertObj;

        public ChangePasswordStep()
        {
            profileTabComponentsObj = new ProfileTabComponents();
            passwordComponentsObj = new PasswordComponents();
            passwordAssertObj = new PasswordAssert();
        }

        public void NewPasswordData()
        {
            List<PasswordTestModel> PasswordFile = JsonHelper.ReadTestDataFromJson<PasswordTestModel>("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\JsonFile\\PasswordFile.json");
            foreach (PasswordTestModel model in PasswordFile)
            {
              //  profileTabComponentsObj.ClickUserName();
                passwordComponentsObj.addPassword(model);
                PasswordAssert.AddPasswordAssert();
            }
        }
    }
}
