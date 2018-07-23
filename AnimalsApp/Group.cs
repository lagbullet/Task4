using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsApp
{
    class Group<T> : List<T> where T : IAnimal
    {
        public void Show()
        {
            foreach (IAnimal animal in this)
            {
                animal.Show();
            }
        }
    }
}
