using System;

namespace DuckSimulator.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base("Rubber"){}

        public override void Quack()
        {
            Console.Write($"\r\nRubber Duck says \"Squeak\".");
        }
    }
}