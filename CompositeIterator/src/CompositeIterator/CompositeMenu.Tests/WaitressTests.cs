using System.Collections.Generic;
using CompositeMenu.Aggregates;
using CompositeMenu.Client;
using CompositeMenu.Logging;
using FakeItEasy;
using NUnit.Framework;

namespace CompositeMenu.Tests
{
    public class WaitressTests
    {
        [Test]
        public void Should_print_all_menus()
        {
            var consoleWriter = A.Fake<ICompositeMenuConsole>();
            
            var pancakeHouseMenu = new PancakeHouseMenu("Breakfast", "PancakeHouse description");
            pancakeHouseMenu.AddMenuItem(
                name: "Regular Pancake Breakfast",
                description: "Pancakes with fried eggs and sausage",
                price: 5.5,
                isVegetarian: false);
            
            var dinerMenu = new DinerMenu("Diner", "Diner description");
            dinerMenu.AddMenuItem(
                name: "Classic Beef",
                description: "100% 6oz British prime beef patty, house mayo, relish, salad",
                price: 8.5,
                isVegetarian: false);
            dinerMenu.AddMenuItem(
                name: "Fish and Chips",
                description: "Beer battered cod with mushy peas and tartar sauce",
                price: 12.5,
                isVegetarian: false);
            
            var waitress = new Waitress(consoleWriter, new List<IEnumerable<MenuItem>>
            {
                pancakeHouseMenu,
                dinerMenu
            });
            
            waitress.PrintAll();

            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("*Menu*"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Breakfast Menu"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("PancakeHouse description"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Regular Pancake Breakfast -- 5.5"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Diner Menu"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Diner description"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Classic Beef -- 8.5"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Fish and Chips -- 12.5"))).MustHaveHappened();
        }

        [Test]
        public void Should_print_all_composite_menus()
        {
            var consoleWriter = A.Fake<ICompositeMenuConsole>();

            //We will replace List<IEnumerable<MenuItem>> with a composite object and populate it
            var waitress = new Waitress(consoleWriter, new List<IEnumerable<MenuItem>>
            {
                
            });

            waitress.PrintAll();

            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("*Menu*"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Breakfast Menu"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("PancakeHouse description"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Regular Pancake Breakfast -- 5.5"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Diner Menu"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Diner description"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Classic Beef -- 8.5"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Fish and Chips -- 12.5"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Dessert Menu"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Dessert description"))).MustHaveHappened();
            A.CallTo(() => consoleWriter.WriteLine(A<string>.That.Contains("Apple Pie -- 4.5"))).MustHaveHappened();
        }
    }
}