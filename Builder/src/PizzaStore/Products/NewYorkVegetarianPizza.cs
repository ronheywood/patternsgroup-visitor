using PizzaStore.Interfaces;

namespace PizzaStore.Products
{
    public class NewYorkVegetarianPizza : Pizza
    {
        public NewYorkVegetarianPizza(IConsole pizzaLogger) : base(pizzaLogger)
        {
            Name = "New York style vegetarian pizza";         
            Toppings.Add("Grated Reggiano Cheese");   
            Toppings.Add("Mushrooms");
            Toppings.Add("Onions");
            Toppings.Add("Red Peppers");
        }
    }
}