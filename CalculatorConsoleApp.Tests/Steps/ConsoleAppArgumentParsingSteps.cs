using NUnit.Framework;
using System;
using TechTalk.SpecFlow;


namespace CalculatorConsoleApp.Tests.Steps
{
    [Binding]
    public class ConsoleAppArgumentParsingSteps
    {
        private string[] _argv;

        [Given(@"an epmty argv array containting")]
       public void GivenAnEpmtyArgVArrayContainting(Table table)
        {
            _argv = new string[table.RowCount];

            var i = 0;

            foreach (var row in table.Rows)
            {
                _argv[i] = row["Value"];
                i++;
            }
        }

        [When(@"console app is passed argv")]
        public void WhenConsoleAppIsPassedArgv()
        {
            Program.Main(_argv);
        }

        [Then(@"console apps opperator is ""(.*)""")]
        public void ThenConsoleAppsOpperatorIs(string p0)
        {
            Assert.AreEqual(p0, Program.Operator);
        }

        [Then(@"console apps values contains (.*)")]
        public void ThenConsoleAppsValuesContains(int p0)
        {
            Assert.AreEqual(p0, Program.Operator);
        }

        [Then(@"counsel apps result should be (.*)")]
        public void ThenCounselAppsResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
