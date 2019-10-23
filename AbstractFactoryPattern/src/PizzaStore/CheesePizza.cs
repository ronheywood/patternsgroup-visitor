namespace PizzaStore
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(IConsole console) : base(console){}
        public override void AddToppings()
        {
            _console.WriteLine("Adding tomato sauce, and cheese.");
        }

        public override string GetName()
        {
            return "Cheese Pizza";
        }
    }
}