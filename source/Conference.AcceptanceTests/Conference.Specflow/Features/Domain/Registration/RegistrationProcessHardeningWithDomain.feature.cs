﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Domain.Registration
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class TheRegistrationProcessShouldBeAbleToRecoverFromUnexpectedConditionsAndFailuresFeature : Xunit.IUseFixture<TheRegistrationProcessShouldBeAbleToRecoverFromUnexpectedConditionsAndFailuresFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RegistrationProcessHardeningWithDomain.feature"
#line hidden
        
        public TheRegistrationProcessShouldBeAbleToRecoverFromUnexpectedConditionsAndFailuresFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "The RegistrationProcess should be able to recover from unexpected conditions and " +
                    "failures", "There are two general issues to consider\r\nMessages are handled successfully but t" +
                    "hey cannot be completed so they are handled again and\r\nthe process state is stor" +
                    "ed but the commands it generates fail to be published", ProgrammingLanguage.CSharp, new string[] {
                        "RegistrationProcessHardeningWithDomain",
                        "NoWatiN"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(TheRegistrationProcessShouldBeAbleToRecoverFromUnexpectedConditionsAndFailuresFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "The RegistrationProcess should be able to recover from unexpected conditions and " +
            "failures")]
        [Xunit.TraitAttribute("Description", "Crashes or is unable to access storage after receiving an event and before it sen" +
            "ds any commands")]
        public virtual void CrashesOrIsUnableToAccessStorageAfterReceivingAnEventAndBeforeItSendsAnyCommands()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Crashes or is unable to access storage after receiving an event and before it sen" +
                    "ds any commands", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199",
                        "100"});
            table1.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "100"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50",
                        "100"});
#line 30
testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 35
testRunner.And("the selected Order Items", ((string)(null)), table2);
#line 39
testRunner.When("the Registrant proceed to make the Reservation");
#line 41
testRunner.Then("the command to register the selected Order Items is received");
#line 43
testRunner.And("the event for Order placed is emitted");
#line 45
testRunner.And("the command for reserving the selected Seats is received");
#line 47
testRunner.And("the event for reserving the selected Seats is emitted");
#line 49
testRunner.And("the command for marking the selected Seats as reserved is received");
#line 51
testRunner.And("the event for completing the Order reservation is emitted");
#line 53
testRunner.And("the event for calculating the total of $249 is emitted");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                TheRegistrationProcessShouldBeAbleToRecoverFromUnexpectedConditionsAndFailuresFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                TheRegistrationProcessShouldBeAbleToRecoverFromUnexpectedConditionsAndFailuresFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
