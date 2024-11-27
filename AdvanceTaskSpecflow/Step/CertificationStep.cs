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
    public class CertificationStep : CommonDriver
    {
        ProfileTabComponents profileTabComponentsObj;
        AddDeleteCertification addDeleteCertificationObj;
        CertificationsAssert certificationsAssertObj;

        public CertificationStep()
        {
            profileTabComponentsObj = new ProfileTabComponents();
            addDeleteCertificationObj = new AddDeleteCertification();
            certificationsAssertObj = new CertificationsAssert();
        }

        public void AddCertificationData()
        {

            List<CertificationTestModel> AddCertificationfile = JsonHelper.ReadTestDataFromJson<CertificationTestModel>("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\JsonFile\\AddCertificationfile.json");
            foreach (CertificationTestModel model in AddCertificationfile)
            {
                profileTabComponentsObj.cilckCertificationTab();
                
                addDeleteCertificationObj.addNewCertification(model);
               
                CertificationsAssert.AddCertificationAssert();
            }
        }
        public void DeleteCertificationData()
        {

            List<CertificationTestModel> DeleteCertificationfile = JsonHelper.ReadTestDataFromJson<CertificationTestModel>("F:\\Advance Task\\AdvanceTaskSprint2\\AdvanceTaskSpecflow\\JsonFile\\DeleteCertification.json");
            foreach (CertificationTestModel model in DeleteCertificationfile)
            {
                profileTabComponentsObj.cilckCertificationTab();
                addDeleteCertificationObj.addNewCertification(model);
                addDeleteCertificationObj.DeleteCertification(model);
                CertificationsAssert.DeleteCertificationAssert();
                
            }
        }
    }
}
