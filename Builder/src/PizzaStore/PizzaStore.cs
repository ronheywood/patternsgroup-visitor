using PizzaStore.Interfaces;
using PizzaStore.Products;

namespace PizzaStore
{
    public class PizzaStore : FranchisedPizzaStore
    {
        private readonly IIngredientFactory _ingredientFactory;

        public PizzaStore(IConsole console, IIngredientFactory ingredientFactory) : base(console, ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        protected override Pizza CreatePizza(string type, IConsole console)
        {
            var pizza = new CheesePizza(console,_ingredientFactory);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}