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
            var pizza = new CheesePizza(_console);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }
    }
}