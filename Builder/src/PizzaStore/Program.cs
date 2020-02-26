using PizzaStore.Logging;

namespace PizzaStore
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var console = new PizzaLogger();
            console.WriteLine("Welcome to the Spektrix Pizza Store New York!");
            var nyPizzaStore = new PizzaStore(console,new ChicagoIngredientsFactory());
            var pizzaA = nyPizzaStore.OrderPizza("Vegetarian");
            console.WriteLine($"I ordered you a {pizzaA.GetName()}");
            
//            console.WriteLine("\r\nWelcome to the Spektrix Pizza Store New York!");
//            console.WriteLine($"I ordered you a {pizzaA.GetName()}");
//            var chicagoPizzaStore = new ChicagoPizzaStore(console);
//            var pizzaB = chicagoPizzaStore.OrderPizza("Vegetarian");
//            console.WriteLine($"I ordered you a {pizzaB.GetName()}");
//            console.ReadKey();
        }
    }
}