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
            Group groups = new Group();
            groups.AddNew("Cow", "qwerty", 10);
            groups.AddNew("Pig", "asdfgh", 3);
            groups.AddNew("Cat", "zxcvbn", 4);
            groups.AddNew("Dog", "bghtyh", 5);
            groups.AddNew("Sheep", "edsqwa", 2);
            groups.Show();
            Console.WriteLine(groups.CowTalk());
            Console.ReadKey();

        }
    }
}
