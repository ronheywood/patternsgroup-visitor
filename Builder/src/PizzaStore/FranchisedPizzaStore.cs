using PizzaStore.Interfaces;
using PizzaStore.Logging;
using PizzaStore.Products;

namespace PizzaStore
{
    public abstract class FranchisedPizzaStore
    {
        private readonly IConsole _console;
        private readonly IIngredientFactory _ingredientFactory;

        protected FranchisedPizzaStore(IConsole console, IIngredientFactory ingredientFactory)
        {
            _console = console;
            _ingredientFactory = ingredientFactory;
        }
        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type, _console);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type,IConsole console);
    }
}