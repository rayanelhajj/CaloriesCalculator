﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CaloriesCalculator.SpecFlow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CalculateBasicCaloriesFeature : Xunit.IClassFixture<CalculateBasicCaloriesFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CalculateBasicCalories.feature"
#line hidden
        
        public CalculateBasicCaloriesFeature(CalculateBasicCaloriesFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CalculateBasicCalories", "\tIn order to know my basic energy needs\r\n\tAs a user\r\n\tI want to calculate my basi" +
                    "c calories intake", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Calculate basic calories for a male aged between 18 and 30")]
        [Xunit.TraitAttribute("FeatureTitle", "CalculateBasicCalories")]
        [Xunit.TraitAttribute("Description", "Calculate basic calories for a male aged between 18 and 30")]
        [Xunit.InlineDataAttribute("18", "0", "70", "1757", new string[0])]
        [Xunit.InlineDataAttribute("22", "0", "70", "1757", new string[0])]
        [Xunit.InlineDataAttribute("29", "0", "70", "1757", new string[0])]
        public virtual void CalculateBasicCaloriesForAMaleAgedBetween18And30(string age, string gender, string weight, string calories, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate basic calories for a male aged between 18 and 30", null, exampleTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
testRunner.Given(string.Format("I have entered {0} and {1} and {2}", age, gender, weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
testRunner.When("I press calculate basic calories", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
testRunner.Then(string.Format("the result should be {0} on the screen", calories), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Calculate basic calories for a female aged between 18 and 30")]
        [Xunit.TraitAttribute("FeatureTitle", "CalculateBasicCalories")]
        [Xunit.TraitAttribute("Description", "Calculate basic calories for a female aged between 18 and 30")]
        [Xunit.InlineDataAttribute("18", "1", "70", "1525", new string[0])]
        [Xunit.InlineDataAttribute("22", "1", "70", "1525", new string[0])]
        [Xunit.InlineDataAttribute("29", "1", "70", "1525", new string[0])]
        public virtual void CalculateBasicCaloriesForAFemaleAgedBetween18And30(string age, string gender, string weight, string calories, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate basic calories for a female aged between 18 and 30", null, exampleTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 18
testRunner.Given(string.Format("I have entered {0} and {1} and {2}", age, gender, weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
testRunner.When("I press calculate basic calories", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
testRunner.Then(string.Format("the result should be {0} on the screen", calories), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Calculate basic calories for a male aged between 30 and 60")]
        [Xunit.TraitAttribute("FeatureTitle", "CalculateBasicCalories")]
        [Xunit.TraitAttribute("Description", "Calculate basic calories for a male aged between 30 and 60")]
        [Xunit.InlineDataAttribute("30", "0", "70", "1691", new string[0])]
        [Xunit.InlineDataAttribute("45", "0", "70", "1691", new string[0])]
        [Xunit.InlineDataAttribute("59", "0", "70", "1691", new string[0])]
        public virtual void CalculateBasicCaloriesForAMaleAgedBetween30And60(string age, string gender, string weight, string calories, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate basic calories for a male aged between 30 and 60", null, exampleTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 29
testRunner.Given(string.Format("I have entered {0} and {1} and {2}", age, gender, weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
testRunner.When("I press calculate basic calories", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
testRunner.Then(string.Format("the result should be {0} on the screen", calories), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Calculate basic calories for a female aged between 30 and 60")]
        [Xunit.TraitAttribute("FeatureTitle", "CalculateBasicCalories")]
        [Xunit.TraitAttribute("Description", "Calculate basic calories for a female aged between 30 and 60")]
        [Xunit.InlineDataAttribute("30", "1", "70", "1438", new string[0])]
        [Xunit.InlineDataAttribute("45", "1", "70", "1438", new string[0])]
        [Xunit.InlineDataAttribute("59", "1", "70", "1438", new string[0])]
        public virtual void CalculateBasicCaloriesForAFemaleAgedBetween30And60(string age, string gender, string weight, string calories, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate basic calories for a female aged between 30 and 60", null, exampleTags);
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 40
testRunner.Given(string.Format("I have entered {0} and {1} and {2}", age, gender, weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
testRunner.When("I press calculate basic calories", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
testRunner.Then(string.Format("the result should be {0} on the screen", calories), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Calculate basic calories for a male aged 60 or older")]
        [Xunit.TraitAttribute("FeatureTitle", "CalculateBasicCalories")]
        [Xunit.TraitAttribute("Description", "Calculate basic calories for a male aged 60 or older")]
        [Xunit.InlineDataAttribute("60", "0", "70", "1432", new string[0])]
        [Xunit.InlineDataAttribute("78", "0", "70", "1432", new string[0])]
        [Xunit.InlineDataAttribute("83", "0", "70", "1432", new string[0])]
        [Xunit.InlineDataAttribute("101", "0", "70", "1432", new string[0])]
        public virtual void CalculateBasicCaloriesForAMaleAged60OrOlder(string age, string gender, string weight, string calories, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate basic calories for a male aged 60 or older", null, exampleTags);
#line 50
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 51
testRunner.Given(string.Format("I have entered {0} and {1} and {2}", age, gender, weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
testRunner.When("I press calculate basic calories", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
testRunner.Then(string.Format("the result should be {0} on the screen", calories), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Calculate basic calories for a female aged 60 or older")]
        [Xunit.TraitAttribute("FeatureTitle", "CalculateBasicCalories")]
        [Xunit.TraitAttribute("Description", "Calculate basic calories for a female aged 60 or older")]
        [Xunit.InlineDataAttribute("60", "1", "70", "1331", new string[0])]
        [Xunit.InlineDataAttribute("78", "1", "70", "1331", new string[0])]
        [Xunit.InlineDataAttribute("83", "1", "70", "1331", new string[0])]
        [Xunit.InlineDataAttribute("101", "1", "70", "1331", new string[0])]
        public virtual void CalculateBasicCaloriesForAFemaleAged60OrOlder(string age, string gender, string weight, string calories, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate basic calories for a female aged 60 or older", null, exampleTags);
#line 62
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 63
testRunner.Given(string.Format("I have entered {0} and {1} and {2}", age, gender, weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
testRunner.When("I press calculate basic calories", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
testRunner.Then(string.Format("the result should be {0} on the screen", calories), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CalculateBasicCaloriesFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CalculateBasicCaloriesFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion