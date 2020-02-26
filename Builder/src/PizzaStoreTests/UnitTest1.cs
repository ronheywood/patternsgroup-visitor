using System.Collections.Generic;
using FakeItEasy;
using NUnit.Framework;
using PizzaStore;
using PizzaStore.Interfaces;
using PizzaStore.Products;

namespace PizzaStoreTests
{
    public class PizzaStoreTests
    {
        private static IIngredientFactory chicagoFactory = new ChicagoIngredientsFactory();
        private static IIngredientFactory newYorkFactory = new NewYorkIngredientsFactory();
        [SetUp]
        public void Setup()
        {
        }

        public static List<IIngredientFactory> Factories = new List<IIngredientFactory>()
            {chicagoFactory, newYorkFactory};
            
        [TestCaseSource(nameof(Factories))]
        public void It_should_order_pizza(IIngredientFactory factory)
        {
            var console = A.Fake<IConsole>();
            var pizzaStore = new PizzaStore.PizzaStore(console,factory);
            Assert.That(pizzaStore.OrderPizza("cheese"),Is.InstanceOf<CheesePizza>());
        }

        [TestCaseSource(nameof(Factories))]
        public void Should_prepare_pizza_before_returning_iz(IIngredientFactory factory)
        {
            var console = A.Fake<IConsole>();
            var pizzaStore = new PizzaStore.PizzaStore(console,factory);
            pizzaStore.OrderPizza("cheese");
            A.CallTo(() => console.WriteLine("Preparing Cheese Pizza")).MustHaveHappened();
        }

        [TestCaseSource(nameof(Factories))]
        public void Should_bake_pizza_before_returning_it(IIngredientFactory factory)
        {
            var console = A.Fake<IConsole>();
            var pizzaStore = new PizzaStore.PizzaStore(console,factory);
            pizzaStore.OrderPizza("cheese");
            A.CallTo(() => console.WriteLine("Baking pizza at 220 degrees celsius for 14 minutes.")).MustHaveHappened();
        }
        
        [TestCaseSource(nameof(Factories))]
        public void Should_cut_pizza_before_returning_it(IIngredientFactory factory)
        {
            var console = A.Fake<IConsole>();
            var pizzaStore = new PizzaStore.PizzaStore(console,factory);
            pizzaStore.OrderPizza("cheese");
            A.CallTo(() => console.WriteLine("Cutting the pizza into diagonal slices.")).MustHaveHappened();
        }
        
        [TestCaseSource(nameof(Factories))]
        public void Should_box_pizza_before_returning_i(IIngredientFactory factory)
        {
            var console = A.Fake<IConsole>();
            var pizzaStore = new PizzaStore.PizzaStore(console,factory);
            pizzaStore.OrderPizza("cheese");
            A.CallTo(() => console.WriteLine("Place pizza in a box.")).MustHaveHappened();
        }

        [TestCaseSource(nameof(Factories))]
        public void Cheese_ingredient_should_change(IIngredientFactory factory)
        {
            var console = A.Fake<IConsole>();
            var expected = (factory.GetType().ToString() == "PizzaStore.ChicagoIngredientsFactory") ? "Mozarella Cheese" : "Raggiano Cheese";
            
            var pizzaStore = new PizzaStore.PizzaStore(console,factory);
            var pizza = pizzaStore.OrderPizza("cheese");
            Assert.That(pizza.Toppings,Does.Contain(expected));
            A.CallTo(() => console.WriteLine($"    {expected}")).MustHaveHappened();
        }
        
        [TestCaseSource(nameof(Factories))]
        public void Dough_ingredient_should_change(IIngredientFactory factory)
        {
            var console = A.Fake<IConsole>();
            var expected = (factory.GetType().ToString() == "PizzaStore.ChicagoIngredientsFactory") ? "Deep Crust" : "Thin Crust";
            
            var pizzaStore = new PizzaStore.PizzaStore(console,factory);
            var pizza = pizzaStore.OrderPizza("cheese");
            Assert.That(pizza.Dough.ToString(),Is.EqualTo(expected));
            //A.CallTo(() => console.WriteLine(A<string>.That.Contains(expected))).MustHaveHappened();
        }

    }
}