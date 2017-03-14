﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace eMBEDAutomationTests.Features.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ValidateEmbedDashboardPageFeatures")]
    [NUnit.Framework.CategoryAttribute("embedsmoketest")]
    public partial class ValidateEmbedDashboardPageFeaturesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ValidateEmbedDashboardPageFeatures.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ValidateEmbedDashboardPageFeatures", "\tThis sanity test is to ensure the state of Dashboard page elements and ensure al" +
                    "l links, panels, etc. \r\n\tare present and work as expected, before the main testi" +
                    "ng takes place", ProgrammingLanguage.CSharp, new string[] {
                        "embedsmoketest"});
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
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("I am logged into eMBED and viewing the Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A top navigation section provides links to CIM, account and view settings")]
        public virtual void ATopNavigationSectionProvidesLinksToCIMAccountAndViewSettings()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A top navigation section provides links to CIM, account and view settings", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 10
 testRunner.Given("the top navigation elements have loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.Then("each goes to the expected location", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A Filter element allows users to select month and year range for analysis")]
        public virtual void AFilterElementAllowsUsersToSelectMonthAndYearRangeForAnalysis()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A Filter element allows users to select month and year range for analysis", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 14
 testRunner.Given("I have clicked on the burger icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("I select a month and year range", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("the data returned matches the date range selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A set of navigation links are shown that take the user to relevent dashboard sect" +
            "ions")]
        public virtual void ASetOfNavigationLinksAreShownThatTakeTheUserToReleventDashboardSections()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A set of navigation links are shown that take the user to relevent dashboard sect" +
                    "ions", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 19
 testRunner.Given("the navigation elements are present on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.And("the SAR \'<item>\' is active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("each other \'<item>\' is present and inactive but selectable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "item",
                        "navLocation"});
            table1.AddRow(new string[] {
                        "SAR",
                        "http://testing05:50000/mbed#/performance"});
            table1.AddRow(new string[] {
                        "RiskStrat",
                        "http://testing05:50000/mbed#/riskstratification"});
            table1.AddRow(new string[] {
                        "GPOS",
                        "http://testing05:50000/mbed#/gpos"});
            table1.AddRow(new string[] {
                        "Performance",
                        "http://testing05:50000/mbed/performance"});
#line 22
 testRunner.Then("they link to the expected \'<navLocation>\'", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Secondary Care Indicators panel can be expanded to view SAR by ACS and by Diagnos" +
            "is data")]
        public virtual void SecondaryCareIndicatorsPanelCanBeExpandedToViewSARByACSAndByDiagnosisData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Secondary Care Indicators panel can be expanded to view SAR by ACS and by Diagnos" +
                    "is data", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 30
 testRunner.Given("I have expanded the Secondary Care Indicators panel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.And("I can see the SAR by ACS and by Diagnosis sections", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("I can expand both of these to view the data in each panel section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A user can export the information on the dashboard to PDF")]
        public virtual void AUserCanExportTheInformationOnTheDashboardToPDF()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A user can export the information on the dashboard to PDF", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 35
 testRunner.Given("I have selected the Export to PDF tool icon in a <panel>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.When("a PDF file save dialogue is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "panel"});
            table2.AddRow(new string[] {
                        "Secondary"});
            table2.AddRow(new string[] {
                        "byACS"});
            table2.AddRow(new string[] {
                        "byDiagnosis"});
#line 37
 testRunner.Then("I can save the PDF and get returned to the main screen", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Footer text provides required copyright notices and reference links")]
        public virtual void FooterTextProvidesRequiredCopyrightNoticesAndReferenceLinks()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Footer text provides required copyright notices and reference links", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 45
 testRunner.Given("the footer has copyright notices and reference links", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.Then("the copyright notices should state the current year", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "linkText",
                        "linkLocation"});
            table3.AddRow(new string[] {
                        "My DR Foster",
                        "http://testing05:50000/"});
            table3.AddRow(new string[] {
                        "Feedback",
                        "OpenUserVoiceDialogue"});
#line 47
 testRunner.And("reference links should go to the correct locations", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
