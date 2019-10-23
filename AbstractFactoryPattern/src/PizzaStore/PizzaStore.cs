namespace PizzaStore
{
    public class PizzaStore
    {
        private readonly IConsole _console;

        public PizzaStore(IConsole console)
        {
            _console = console;
        }

        public Pizza OrderPizza()
        {
            var pizza = new Pizza();
            _console.WriteLine("Preparing pizza");
            _console.WriteLine("Baking pizza at 220 degrees celsius for 14 minutes.");
            _console.WriteLine("Cutting the pizza into diagonal slices.");
            _console.WriteLine("Place pizza in a box.");
            return pizza;
        }
    }
}