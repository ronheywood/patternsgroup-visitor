using PizzaStore.Interfaces;

namespace PizzaStore.Products
{
    public class NewYorkPepperoniPizza : Pizza
    {
        public NewYorkPepperoniPizza(IConsole pizzaLogger) : base(pizzaLogger)
        {
            Name = "New York style pepperoni pizza";         
            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Pepperoni");
        }

    }
}