using PizzaStore.Interfaces;
using PizzaStore.Products.Cheese;
using PizzaStore.Products.Dough;
using PizzaStore.Products.Meat;
using PizzaStore.Products.Sauce;
using PizzaStore.Products.Veggies;

namespace PizzaStore
{
    public class NewYorkIngredientsFactory : IIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrust();
        }

        public Sauce CreateSauce()
        {
            throw new System.NotImplementedException();
        }

        public Cheese CreateCheese()
        {
            return new RaggianoCheese();
        }

        public Veggies[] CreateVeggies()
        {
            throw new System.NotImplementedException();
        }

        public Pepperoni CreatePepperoni()
        {
            throw new System.NotImplementedException();
        }

        public Clams CreateClams()
        {
            throw new System.NotImplementedException();
        }
    }
}