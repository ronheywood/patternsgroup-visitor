using BreakfastAndLunchMenu.Client;
using BreakfastAndLunchMenu.Domain.Menu;
using BreakfastAndLunchMenu.Log;
using FakeItEasy;
using NUnit.Framework;

namespace BreakfastAndLunchMenuTests
{
    [TestFixture]
    public class WaitressTests
    {
        [Test]
        public void Should_print_all_menus()
        {
            var consoleWriter = A.Fake<IBreakfastLunchConsole>();
            var waitress = new Waitress(consoleWriter, new PancakeHouseMenu(), new DinerMenu());
            waitress.PrintMenu();

            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("*Menu*"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Breakfast Menu"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Regular Pancake Breakfast -- 5.5"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Blueberry Pancakes -- 6.5"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Waffles -- 5"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Diner Menu"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Cottage Pie -- 11"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Soup of the Day -- 6.5"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Fish and Chips -- 12.5"))).MustHaveHappened();
        }
    }
}
