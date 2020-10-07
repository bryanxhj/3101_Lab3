using _3101_Lab1;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {

        //Context Injection for SpecFLow:
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorAvailabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }
        //--------------------------------

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            try
            {
                _result = _calculator.Availability(p0, p1);
            }
            catch (Exception err) 
            {
                ScenarioContext.Current[("Error")] = err;
            }
        }
        
        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the availability result should be an error message")]
        public void ThenTheAvailabilityResultShouldBeAnErrorMessage()
        {
            Assert.IsTrue(ScenarioContext.Current.ContainsKey("Error"));
        }
    }
}
