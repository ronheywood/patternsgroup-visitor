namespace PizzaStore
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var console = new PizzaLogger();
            console.WriteLine("Welcome to the Spektrix Pizza Store!");
            var pizzaStore = new PizzaStore(console);
            var pizza = pizzaStore.OrderPizza();
            console.WriteLine($"I ordered you a {pizza.GetName()}");
            console.ReadKey();
        }
    }
}