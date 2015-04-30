using System;
using TechTalk.SpecFlow;
using Should.Fluent;

namespace SeniorStudent.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class StudentHasAnExamSoonSteps
    {
                [Given(@"I am a student")]
        public void GivenIAmAStudent()
        {
            var student = new Student();
            ScenarioContext.Current.Set(student);
        }

                [Given(@"I have a textbook")]
        public void GivenIHaveATextbook()
        {
            var textbook = new TextBook();
            ScenarioContext.Current.Set(textbook);
        }

                [Given(@"I have not read the textbook")]
        public void GivenIHaveNotReadTheTextbook()
        {
            var textbook = ScenarioContext.Current.Get<TextBook>();
            textbook.HasBeenRead = false;
            ScenarioContext.Current.Set(textbook);
        }

                [Given(@"I have read the textbook")]
        public void GivenIHaveReadTheTextbook()
        {
            var textbook = ScenarioContext.Current.Get<TextBook>();
            textbook.HasBeenRead = true;
            ScenarioContext.Current.Set(textbook);
        }

                [When(@"I study for the exam that is in five minutes")]
        public void WhenIStudyForTheExamThatIsInFiveMinutes()
        {
            var student = ScenarioContext.Current.Get<Student>();
            var textbook = ScenarioContext.Current.Get<TextBook>();

            student.StudyForExam(textbook);
        }

                [Then(@"I will die")]
        public void ThenIWillDie()
        {
            var student = ScenarioContext.Current.Get<Student>();
            student.IsAlive.Should().Be.False();
        }

                [Then(@"I will be okay :\)")]
        public void ThenIWillBeOkay()
        {
            var student = ScenarioContext.Current.Get<Student>();
            student.IsAlive.Should().Be.True();
        }
    }
}
