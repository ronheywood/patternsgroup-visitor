using PizzaStore.Products;

namespace PizzaStore
{
    public interface IPizzaFactory
    {
        Pizza MakeCheesePizza();
        Pizza MakePepperoniPizza();
        Pizza MakeVegetarianPizza();
    }
}