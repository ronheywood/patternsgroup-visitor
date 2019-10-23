using System;
using FakeItEasy;
using NUnit.Framework;
using PizzaStore;

namespace PizzaStoreTests
{
    public class PizzaStoreTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void It_should_order_pizza()
        {
            var console = A.Fake<IConsole>();
            var pizzaStore = new PizzaStore.PizzaStore(console);
            Assert.That(pizzaStore.OrderPizza(),Is.InstanceOf<Pizza>());
        }

        [Test]
        public void Should_prepare_pizza_before_returning_iz()
        {
            var console = A.Fake<IConsole>();
            var pizzaStore = new PizzaStore.PizzaStore(console);
            pizzaStore.OrderPizza();
            A.CallTo(() => console.WriteLine("Preparing pizza.")).MustHaveHappened();
        }

        [Test]
        public void Should_bake_pizza_before_returning_it()
        {
            var console = A.Fake<IConsole>();
            var pizzaStore = new PizzaStore.PizzaStore(console);
            pizzaStore.OrderPizza();
            A.CallTo(() => console.WriteLine("Baking pizza at 220 degrees celsius for 14 minutes.")).MustHaveHappened();
        }
        [Test]
        public void Should_cut_pizza_before_returning_it()
        {
            var console = A.Fake<IConsole>();
            var pizzaStore = new PizzaStore.PizzaStore(console);
            pizzaStore.OrderPizza();
            A.CallTo(() => console.WriteLine("Cutting the pizza into diagonal slices.")).MustHaveHappened();
        }

        [Test]
        public void Should_box_pizza_before_returning_i()
        {
            var console = A.Fake<IConsole>();
            var pizzaStore = new PizzaStore.PizzaStore(console);
            pizzaStore.OrderPizza();
            A.CallTo(() => console.WriteLine("Place pizza in a box.")).MustHaveHappened();
        }

    }
}