using PizzaStore.Interfaces;
using PizzaStore.Logging;

namespace PizzaStore.Products
{
    public class CheesePizza : Pizza
    {
        private readonly IConsole _console;
        private readonly IIngredientFactory _ingredientFactory;

        public CheesePizza(IConsole console, IIngredientFactory ingredientFactory) : base(console)
        {
            _console = console;
            _ingredientFactory = ingredientFactory;
            Name = "Cheese Pizza";
            Dough = ingredientFactory.CreateDough();
            Toppings.Add(_ingredientFactory.CreateCheese().GetName());
        }
    }
}