using PizzaStore.Products.Cheese;
using PizzaStore.Products.Dough;
using PizzaStore.Products.Sauce;

namespace PizzaStore.Interfaces
{
    public interface IPizzaBuilder
    {
        IPizzaBuilder TossDough(Dough dough);
        IPizzaBuilder AddSauce(Sauce sauce);
        IPizzaBuilder AddCheese(Cheese cheese);
        IPizzaBuilder AddTopping(PizzaTopping topping);
    }
}
