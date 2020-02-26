using System.Collections.Generic;
using PizzaStore.Interfaces;
using PizzaStore.Logging;

namespace PizzaStore.Products
{
    public abstract class Pizza
    {
        protected readonly IConsole _console;

        public readonly IList<string> Toppings = new List<string>();
        protected string Name { get; set; }
        public Dough.Dough Dough { get; set; }
        protected string Sauce { get; set; }
        
        protected Pizza(IConsole console)
        {
            _console = console;
        }

        public void Prepare()
        {
            _console.WriteLine("Preparing " + GetName());
            _console.WriteLine("Tossing dough...");
            _console.WriteLine("Adding sauce...");
            _console.WriteLine("Adding toppings:");
            foreach (var topping in Toppings)
            {
                _console.WriteLine("    " + topping);    
            }
        }

        public virtual void Bake()
        {
            _console.WriteLine("Baking pizza at 220 degrees celsius for 14 minutes.");
        }

        public virtual void Cut()
        {
            _console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public virtual void Box()
        {
            _console.WriteLine("Place pizza in a box.");
        }

        public string GetName() => Name;
    }
}