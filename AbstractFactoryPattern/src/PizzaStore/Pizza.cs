namespace PizzaStore
{
    public abstract class Pizza
    {
        protected readonly IConsole _console;

        protected Pizza(IConsole console)
        {
            _console = console;
        }

        public void Prepare()
        {
            _console.WriteLine("Preparing pizza.");
            AddToppings();
        }
        public abstract void AddToppings();

        public void Bake()
        {
            _console.WriteLine("Baking pizza at 220 degrees celsius for 14 minutes.");
        }

        public void Cut()
        {
            _console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public void Box()
        {
            _console.WriteLine("Place pizza in a box.");
        }

        public abstract string GetName();
    }
}