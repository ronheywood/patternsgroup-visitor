using PizzaStore.Interfaces;
using PizzaStore.Logging;

namespace PizzaStore.Products
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IConsole console) : base(console)
        {
            Name = "Chicago style Pepperoni Pizza";
        }

    }
}