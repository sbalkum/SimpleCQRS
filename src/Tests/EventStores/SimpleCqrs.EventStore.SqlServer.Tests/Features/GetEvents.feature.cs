// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace SimpleCqrs.EventStore.SqlServer.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Get Events")]
    public partial class GetEventsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GetEvents.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Get Events", "In order to retrieve events from my SQL Server event store\nAs a Simple CQRS devel" +
                    "oper\nI want to pass a request to retrieve events and get the appropriate events " +
                    "back", GenerationTargetLanguage.CSharp, ((string[])(null)));
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
            this.FeatureBackground();
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
#line 7
 testRunner.Given("the connection string to my database is", "Data Source=.\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;MultipleAc" +
                    "tiveResultSets=True;", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Events by aggregate root id")]
        public virtual void GetEventsByAggregateRootId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Events by aggregate root id", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "EventDate",
                        "Data",
                        "Sequence",
                        "AggregateRootId",
                        "EventType"});
            table1.AddRow(new string[] {
                        "3/20/2010 3:01:04 AM",
                        "Serialized Object",
                        "1",
                        "8312E92C-DF1C-4970-A9D5-6414120C3CF7",
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingHappenedEvent, SimpleCqrs.EventSto" +
                            "re.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
            table1.AddRow(new string[] {
                        "3/20/2010 4:01:04 AM",
                        "Serialized Objecta",
                        "2",
                        "D50E4D4F-0893-45B2-92F8-897514812A91",
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingHappenedEvent, SimpleCqrs.EventSto" +
                            "re.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
            table1.AddRow(new string[] {
                        "3/20/2010 5:01:04 AM",
                        "Serialized Object2",
                        "3",
                        "8312E92C-DF1C-4970-A9D5-6414120C3CF7",
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingElseHappenedEvent, SimpleCqrs.Even" +
                            "tStore.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
#line 13
 testRunner.Given("I have the following events in the database", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "Sequence",
                        "97"});
#line 18
 testRunner.And("deserializing \'Serialized Object\' will return a SomethingHappenedEvent with the f" +
                    "ollowing data", ((string)(null)), table2);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Sequence",
                        "98"});
#line 21
 testRunner.And("deserializing \'Serialized Object2\' will return a SomethingElseHappenedEvent with " +
                    "the following data", ((string)(null)), table3);
#line 24
 testRunner.When("I retrieve the domain events for \'8312E92C-DF1C-4970-A9D5-6414120C3CF7\'");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Sequence"});
            table4.AddRow(new string[] {
                        "97"});
            table4.AddRow(new string[] {
                        "98"});
#line 25
 testRunner.Then("I should get back the following DomainEvents", ((string)(null)), table4);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Events by sequence")]
        public virtual void GetEventsBySequence()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Events by sequence", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "EventDate",
                        "Data",
                        "Sequence",
                        "AggregateRootId",
                        "EventType"});
            table5.AddRow(new string[] {
                        "3/20/2010 3:01:04 AM",
                        "Serialized Object",
                        "1",
                        "8312E92C-DF1C-4970-A9D5-6414120C3CF7",
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingHappenedEvent, SimpleCqrs.EventSto" +
                            "re.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
            table5.AddRow(new string[] {
                        "3/20/2010 4:01:04 AM",
                        "Serialized Objecta",
                        "2",
                        "D50E4D4F-0893-45B2-92F8-897514812A91",
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingHappenedEvent, SimpleCqrs.EventSto" +
                            "re.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
            table5.AddRow(new string[] {
                        "3/20/2010 5:01:04 AM",
                        "Serialized Object2",
                        "3",
                        "8312E92C-DF1C-4970-A9D5-6414120C3CF7",
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingElseHappenedEvent, SimpleCqrs.Even" +
                            "tStore.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
#line 31
 testRunner.Given("I have the following events in the database", ((string)(null)), table5);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "Sequence",
                        "97"});
#line 36
 testRunner.And("deserializing \'Serialized Object\' will return a SomethingHappenedEvent with the f" +
                    "ollowing data", ((string)(null)), table6);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "Sequence",
                        "98"});
#line 39
 testRunner.And("deserializing \'Serialized Object2\' will return a SomethingElseHappenedEvent with " +
                    "the following data", ((string)(null)), table7);
#line 42
 testRunner.When("I retrieve the domain events for \'8312E92C-DF1C-4970-A9D5-6414120C3CF7\' and seque" +
                    "nce 2");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Sequence"});
            table8.AddRow(new string[] {
                        "98"});
#line 43
 testRunner.Then("I should get back the following DomainEvents", ((string)(null)), table8);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get events with one event type")]
        public virtual void GetEventsWithOneEventType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get events with one event type", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "EventDate",
                        "Data",
                        "Sequence",
                        "AggregateRootId",
                        "EventType"});
            table9.AddRow(new string[] {
                        "3/20/2010 3:01:04 AM",
                        "Serialized Object",
                        "1",
                        "8312E92C-DF1C-4970-A9D5-6414120C3CF7",
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingHappenedEvent, SimpleCqrs.EventSto" +
                            "re.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
            table9.AddRow(new string[] {
                        "3/20/2010 4:01:04 AM",
                        "Serialized Object2",
                        "2",
                        "D50E4D4F-0893-45B2-92F8-897514812A91",
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingHappenedEvent, SimpleCqrs.EventSto" +
                            "re.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
            table9.AddRow(new string[] {
                        "3/20/2010 5:01:04 AM",
                        "Serialized Object3",
                        "3",
                        "8312E92C-DF1C-4970-A9D5-6414120C3CF7",
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingElseHappenedEvent, SimpleCqrs.Even" +
                            "tStore.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
#line 48
 testRunner.Given("I have the following events in the database", ((string)(null)), table9);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "Sequence",
                        "97"});
#line 53
 testRunner.And("deserializing \'Serialized Object\' will return a SomethingHappenedEvent with the f" +
                    "ollowing data", ((string)(null)), table10);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "Sequence",
                        "98"});
#line 56
 testRunner.And("deserializing \'Serialized Object2\' will return a SomethingHappenedEvent with the " +
                    "following data", ((string)(null)), table11);
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "Sequence",
                        "99"});
#line 59
 testRunner.And("deserializing \'Serialized Object3\' will return a SomethingElseHappenedEvent with " +
                    "the following data", ((string)(null)), table12);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type"});
            table13.AddRow(new string[] {
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingHappenedEvent, SimpleCqrs.EventSto" +
                            "re.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
#line 62
 testRunner.When("I retrieve the domain events for the following types", ((string)(null)), table13);
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Sequence"});
            table14.AddRow(new string[] {
                        "97"});
            table14.AddRow(new string[] {
                        "98"});
#line 65
 testRunner.Then("I should get back the following DomainEvents", ((string)(null)), table14);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get events with two event types")]
        public virtual void GetEventsWithTwoEventTypes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get events with two event types", ((string[])(null)));
#line 70
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "EventDate",
                        "Data",
                        "Sequence",
                        "AggregateRootId",
                        "EventType"});
            table15.AddRow(new string[] {
                        "3/20/2010 3:01:04 AM",
                        "Serialized Object",
                        "1",
                        "8312E92C-DF1C-4970-A9D5-6414120C3CF7",
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingHappenedEvent, SimpleCqrs.EventSto" +
                            "re.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
            table15.AddRow(new string[] {
                        "3/20/2010 4:01:04 AM",
                        "Serialized Object2",
                        "2",
                        "D50E4D4F-0893-45B2-92F8-897514812A91",
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingHappenedEvent, SimpleCqrs.EventSto" +
                            "re.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
            table15.AddRow(new string[] {
                        "3/20/2010 5:01:04 AM",
                        "Serialized Object3",
                        "3",
                        "8312E92C-DF1C-4970-A9D5-6414120C3CF7",
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingElseHappenedEvent, SimpleCqrs.Even" +
                            "tStore.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
#line 71
 testRunner.Given("I have the following events in the database", ((string)(null)), table15);
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "Sequence",
                        "97"});
#line 76
 testRunner.And("deserializing \'Serialized Object\' will return a SomethingHappenedEvent with the f" +
                    "ollowing data", ((string)(null)), table16);
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "Sequence",
                        "98"});
#line 79
 testRunner.And("deserializing \'Serialized Object2\' will return a SomethingHappenedEvent with the " +
                    "following data", ((string)(null)), table17);
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "Sequence",
                        "99"});
#line 82
 testRunner.And("deserializing \'Serialized Object3\' will return a SomethingElseHappenedEvent with " +
                    "the following data", ((string)(null)), table18);
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type"});
            table19.AddRow(new string[] {
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingHappenedEvent, SimpleCqrs.EventSto" +
                            "re.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
            table19.AddRow(new string[] {
                        "SimpleCqrs.EventStore.SqlServer.Tests.SomethingElseHappenedEvent, SimpleCqrs.Even" +
                            "tStore.SqlServer.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
#line 85
 testRunner.When("I retrieve the domain events for the following types", ((string)(null)), table19);
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Sequence"});
            table20.AddRow(new string[] {
                        "97"});
            table20.AddRow(new string[] {
                        "98"});
            table20.AddRow(new string[] {
                        "99"});
#line 89
 testRunner.Then("I should get back the following DomainEvents", ((string)(null)), table20);
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
