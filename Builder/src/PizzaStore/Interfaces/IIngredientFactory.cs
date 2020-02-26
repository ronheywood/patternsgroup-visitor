using PizzaStore.Products.Cheese;
using PizzaStore.Products.Dough;
using PizzaStore.Products.Meat;
using PizzaStore.Products.Sauce;
using PizzaStore.Products.Veggies;

namespace PizzaStore.Interfaces
{
    public interface IIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Veggies[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClams();
    }
}