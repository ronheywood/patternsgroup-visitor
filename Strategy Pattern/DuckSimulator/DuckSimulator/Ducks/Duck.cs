using System;

namespace DuckSimulator.Ducks
{
    public class Duck
    {
        private readonly string _name;

        public Duck(string name)
        {
            _name = name + " Duck";
        }

        public override string ToString()
        {
            return _name;
        }

        public virtual void Display()
        {
            Console.Write($"{_name}\r\n");
        }

        public virtual void Swim()
        {
            Console.Write($"\r\n{_name} is swimming.");
        }

        public virtual void Quack()
        {
            Console.Write($"\r\n{_name} says \"Quack\".");
        }
    }
}