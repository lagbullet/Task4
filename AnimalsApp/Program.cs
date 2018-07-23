using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Group<IAnimal> group = new Group<IAnimal>();
            group.Add(new Pig("Pig", 3));
            group.Add(new Cat("Cat", 5));
            group.Add(new Dog("Dog", 8));
            group.Add(new Cow("Cow", 6));
            group.Add(new Sheep("Sheep", 6));
            group.Show();
            Console.ReadKey();
        }
    }

}
