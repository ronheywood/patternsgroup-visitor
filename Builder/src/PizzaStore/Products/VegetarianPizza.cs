using PizzaStore.Interfaces;
using PizzaStore.Logging;

namespace PizzaStore.Products
{
    public class VegetarianPizza : Pizza
    {
        public VegetarianPizza(IConsole console) : base(console)
        {
            Name = "Chicago style Vegetarian Pizza"; 
            Toppings.Add("Shredded Mozzarella Cheese");
            Toppings.Add("Parmesan");
            Toppings.Add("Eggplant");
            Toppings.Add("Spinach");
            Toppings.Add("Black Olives");
        }
    }
}