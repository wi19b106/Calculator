using System;
using TechTalk.SpecFlow;

namespace Calculator
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"the object Math\.pi")]
        public void GivenTheObjectMath_Pi()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"(.*) and function Math\.sinus")]
        public void GivenAndFunctionMath_Sinus(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"(.*) and function Math\.cos")]
        public void GivenAndFunctionMath_Cos(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"(.*) and function Math\.tang")]
        public void GivenAndFunctionMath_Tang(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"calling pi function")]
        public void WhenCallingPiFunction()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"passing (.*)")]
        public void WhenPassing(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be exaclty pi")]
        public void ThenTheResultShouldBeExacltyPi()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"should return Sin\(number\)")]
        public void ThenShouldReturnSinNumber()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
