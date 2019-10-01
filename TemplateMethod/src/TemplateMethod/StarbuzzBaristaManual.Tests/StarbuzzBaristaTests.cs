using FakeItEasy;
using NUnit.Framework;
using StarbuzzBaristaManual.Logging;

namespace StarbuzzBaristaManual.Tests
{
    public class StarbuzzBaristaTests
    {
        [Test]
        public void Should_prepare_a_coffee()
        {
            var consoleWriter = A.Fake<IConsole>();

            var coffee = new Coffee();

            coffee.prepare();

            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Coffee preparation in progress"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Boiling water"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Brewing coffee in boiling water"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Pouring coffee in a cup"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Adding sugar and milk"))).MustHaveHappened();
        }

        //--Let's comment this for the time being!--
        //[Test]
        //public void Should_prepare_a_tea()
        //{
        //    var consoleWriter = A.Fake<IConsole>();

        //    var tea = new Tea();

        //    tea.prepare();

        //    A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Tea preparation in progress"))).MustHaveHappened();
        //    A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Boiling water"))).MustHaveHappened();
        //    A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Steep tea in boiling water"))).MustHaveHappened();
        //    A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Pouring tea in a cup"))).MustHaveHappened();
        //    A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Add lemon"))).MustHaveHappened();
        //}
    }
}