using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsApp
{
    class Pig : IAnimal
    {
        private string _Name;
        private int _Age;

        public string Name { get; set; }
        public int Age { get; set; }

        public string Talk()
        {
            return "Sqee";
        }

        public Pig() { }

        public Pig(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
