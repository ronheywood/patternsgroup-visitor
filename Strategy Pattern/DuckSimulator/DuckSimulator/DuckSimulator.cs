using System;
using System.Collections.Generic;
using System.Linq;
using DuckSimulator.Ducks;

namespace DuckSimulator
{
    internal class DuckSimulator
    {
        private static List<Duck> _ducks;

        public DuckSimulator(IEnumerable<Duck> ducks)
        {
            _ducks = ducks.ToList();
        }
        public void SimulateDucks()
        {
            Console.WriteLine("Look at all of the lovely ducks!");
            _ducks.ForEach(d => d.Display());
        }

        public void MakeDucksQuack()
        {
            _ducks.ForEach(d => d.Quack());
            Console.WriteLine();
        }

        public void MakeDucksSwim()
        {
            _ducks.ForEach(d => d.Swim());
            Console.WriteLine("\r\nWow! The ducks are all swimming around. It's so realistic!");
        }
    }
}