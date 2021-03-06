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
    public partial class CalculateActivityNeedsCaloriesFeature : Xunit.IClassFixture<CalculateActivityNeedsCaloriesFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CalculateActivityNeedsCalories.feature"
#line hidden
        
        public CalculateActivityNeedsCaloriesFeature(CalculateActivityNeedsCaloriesFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CalculateActivityNeedsCalories", "\tIn order to know my Activity level calories burned\r\n\tAs a user\r\n\tI want to calcu" +
                    "late my activity energy needs in calories", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [Xunit.TheoryAttribute(DisplayName="Calculate activity calories for lightly active user")]
        [Xunit.TraitAttribute("FeatureTitle", "CalculateActivityNeedsCalories")]
        [Xunit.TraitAttribute("Description", "Calculate activity calories for lightly active user")]
        [Xunit.TraitAttribute("Category", "mytag")]
        [Xunit.InlineDataAttribute("1432", "0", "286.4", new string[0])]
        [Xunit.InlineDataAttribute("1331", "0", "266.2", new string[0])]
        [Xunit.InlineDataAttribute("1757", "0", "351.4", new string[0])]
        public virtual void CalculateActivityCaloriesForLightlyActiveUser(string basicCalories, string activity, string activity_Needs, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate activity calories for lightly active user", null, @__tags);
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given(string.Format("I have calculated my {0}", basicCalories), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And(string.Format("I have entered my {0}", activity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I press calculate activity needs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("the result should be {0}", activity_Needs), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Calculate activity calories for medium active user")]
        [Xunit.TraitAttribute("FeatureTitle", "CalculateActivityNeedsCalories")]
        [Xunit.TraitAttribute("Description", "Calculate activity calories for medium active user")]
        [Xunit.InlineDataAttribute("1432", "1", "429.6", new string[0])]
        [Xunit.InlineDataAttribute("1331", "1", "399.3", new string[0])]
        [Xunit.InlineDataAttribute("1757", "1", "527.1", new string[0])]
        public virtual void CalculateActivityCaloriesForMediumActiveUser(string basicCalories, string activity, string activity_Needs, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate activity calories for medium active user", null, exampleTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
 testRunner.Given(string.Format("I have calculated my {0}", basicCalories), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.And(string.Format("I have entered my {0}", activity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("I press calculate activity needs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then(string.Format("the result should be {0}", activity_Needs), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Calculate activity calories for highly active user")]
        [Xunit.TraitAttribute("FeatureTitle", "CalculateActivityNeedsCalories")]
        [Xunit.TraitAttribute("Description", "Calculate activity calories for highly active user")]
        [Xunit.InlineDataAttribute("1432", "2", "572.8", new string[0])]
        [Xunit.InlineDataAttribute("1331", "2", "532.4", new string[0])]
        [Xunit.InlineDataAttribute("1757", "2", "702.8", new string[0])]
        public virtual void CalculateActivityCaloriesForHighlyActiveUser(string basicCalories, string activity, string activity_Needs, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate activity calories for highly active user", null, exampleTags);
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 32
 testRunner.Given(string.Format("I have calculated my {0}", basicCalories), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.And(string.Format("I have entered my {0}", activity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.When("I press calculate activity needs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then(string.Format("the result should be {0}", activity_Needs), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Calculate activity calories for extremely active user")]
        [Xunit.TraitAttribute("FeatureTitle", "CalculateActivityNeedsCalories")]
        [Xunit.TraitAttribute("Description", "Calculate activity calories for extremely active user")]
        [Xunit.InlineDataAttribute("1432", "3", "716.0", new string[0])]
        [Xunit.InlineDataAttribute("1331", "3", "665.5", new string[0])]
        [Xunit.InlineDataAttribute("1757", "3", "878.5", new string[0])]
        public virtual void CalculateActivityCaloriesForExtremelyActiveUser(string basicCalories, string activity, string activity_Needs, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate activity calories for extremely active user", null, exampleTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 44
 testRunner.Given(string.Format("I have calculated my {0}", basicCalories), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.And(string.Format("I have entered my {0}", activity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.When("I press calculate activity needs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then(string.Format("the result should be {0}", activity_Needs), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CalculateActivityNeedsCaloriesFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CalculateActivityNeedsCaloriesFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
