﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Service.Tests.Acceptance.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ValidateCar")]
    public partial class ValidateCarFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ValidateCar.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ValidateCar", "\tAs a story description \r\n\tWhen i am  writen\r\n\tI would like to contain some infor" +
                    "mation", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Given a car endpoint When that endpoint is called a list of cars is returned")]
        public virtual void GivenACarEndpointWhenThatEndpointIsCalledAListOfCarsIsReturned()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Given a car endpoint When that endpoint is called a list of cars is returned", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "car Type",
                        "registration",
                        "year Bought"});
            table1.AddRow(new string[] {
                        "ford",
                        "jd23riri",
                        "2015"});
            table1.AddRow(new string[] {
                        "porche",
                        "ej29ksks",
                        "2014"});
#line 7
 testRunner.Given("the following car data", ((string)(null)), table1, "Given ");
#line 11
 testRunner.When("the endpoint is called", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("the following data should be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.And("the api will return a response of OK", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
