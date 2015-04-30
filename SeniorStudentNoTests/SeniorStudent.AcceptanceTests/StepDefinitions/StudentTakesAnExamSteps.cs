using System;
using TechTalk.SpecFlow;

namespace SeniorStudent.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class StudentTakesAnExamSteps
    {
        [Given(@"I am a good student")]
public void GivenIAmAGoodStudent()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"I have not procrastinated")]
public void GivenIHaveNotProcrastinated()
{
    ScenarioContext.Current.Pending();
}

        [When(@"I worry about the exam")]
public void WhenIWorryAboutTheExam()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"I will still be okay")]
public void ThenIWillStillBeOkay()
{
    ScenarioContext.Current.Pending();
}
    }
}
