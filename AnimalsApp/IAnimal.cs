using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsApp
{
    interface IAnimal
    {
        string Talk();
        string Name { get; set; }
        int Age { get; set; }
        void Show();
    }
}
