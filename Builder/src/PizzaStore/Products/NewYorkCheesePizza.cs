using PizzaStore.Interfaces;

namespace PizzaStore.Products
{
    public class NewYorkCheesePizza : Pizza
    {
        public NewYorkCheesePizza(IConsole pizzaLogger) : base(pizzaLogger)
        {
            Name = "Cheese Pizza";         
            Toppings.Add("Grated Reggiano Cheese");   
        }
    }
}