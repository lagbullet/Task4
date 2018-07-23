using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsApp
{
    class Sheep : IAnimal
    {
        private string _Name;
        private int _Age;

        public string Name { get; set; }
        public int Age { get; set; }

        public string Talk()
        {
            return "Beee";
        }

        public Sheep() { }

        public Sheep(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
