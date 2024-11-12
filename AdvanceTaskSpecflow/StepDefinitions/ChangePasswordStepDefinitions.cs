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
    public class ChangePasswordStepDefinitions : CommonDriver
    {
        ProfileTabComponents profileTabComponentsObj;
        PasswordComponents passwordComponentsObj;
        ChangePasswordStep changePasswordStepObj;
        SigninPage signinPageObj;
        LoginPage loginPageObj;

        public ChangePasswordStepDefinitions()
        {
            profileTabComponentsObj = new ProfileTabComponents();
            passwordComponentsObj = new PasswordComponents();
            changePasswordStepObj = new ChangePasswordStep();
            signinPageObj = new SigninPage();
            loginPageObj = new LoginPage();
        }
        [Given(@"User able to login mars portal")]
        public void GivenUserAbleToLoginMarsPortal()
        {
           Thread.Sleep(1000);
            signinPageObj.ClickSignIn();
            loginPageObj.LoginSteps();
        }
        [Then(@"if User wants to change password '([^']*)' then must be able to change successfully\.")]
        public void ThenIfUserWantsToChangePasswordThenMustBeAbleToChangeSuccessfully_(string Passwordpath)
        {

           // profileTabComponentsObj.ClickUserName();
            changePasswordStepObj.NewPasswordData();
            LogScreenshot("ChangePassword");

        }


        

    }
}
