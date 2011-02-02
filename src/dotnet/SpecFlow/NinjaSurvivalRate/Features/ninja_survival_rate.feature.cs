// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.4.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

#region Designer generated code

using TechTalk.SpecFlow;

namespace NinjaSurvivalRate.Features
{
    public partial class FightOrFlightFeature
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "ninja_survival_rate.feature"
#line hidden

        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"),
                                                                "Fight or flight",
                                                                "In order to increase the ninja survival rate,\nAs a ninja commander\nI want my ninj" +
                                                                "as to decide whether to take on an\nopponent based on their skill levels",
                                                                GenerationTargetLanguage.CSharp, ((string[]) (null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }

        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Weaker opponent")]
        public virtual void WeakerOpponent()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Weaker opponent", ((string[]) (null)));
#line 7
            this.ScenarioSetup(scenarioInfo);
#line 8
            testRunner.Given("the ninja has a third level black-belt");
#line 9
            testRunner.When("attacked by a samurai");
#line 10
            testRunner.Then("the ninja should engage the opponent");
#line hidden
            testRunner.CollectScenarioErrors();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Stronger opponent")]
        public virtual void StrongerOpponent()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Stronger opponent", ((string[]) (null)));
#line 12
            this.ScenarioSetup(scenarioInfo);
#line 13
            testRunner.Given("the ninja has a third level black-belt");
#line 14
            testRunner.When("attacked by Chuck Norris");
#line 15
            testRunner.Then("the ninja should run for his life");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}

#endregion