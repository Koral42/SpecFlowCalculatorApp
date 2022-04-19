﻿using NUnit.Framework;
using System;
using System.Linq;
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

        [Then(@"console apps values matches")]
        public void ThenConsoleAppsValuesMatches(Table table)
        {
            Assert.AreEqual(table.RowCount, Program.numbers.Count);

            for (var i = 0; i < table.RowCount; i++)
            {
                var expected = int.Parse(table.Rows[i]["Value"]);

                Assert.AreEqual(expected, Program.numbers[i]);
            }
        }

        [When(@"Console App receives the arguments")]
        public void WhenConsoleAppReceivesTheArguments(Table table)
        {

            _argv = new string[table.RowCount];

            var i = 0;

            foreach (var row in table.Rows)
            {
                _argv[i] = row["Value"];
                i++;
            }
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            
            int sum = Program.numbers.Take(2).Sum();

            Assert.AreEqual(p0, sum);

            //ScenarioContext.Current.Pending();
        }


    }
}
