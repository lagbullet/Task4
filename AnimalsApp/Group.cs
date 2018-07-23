using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsApp
{
    class Group
    {
        private List<Cow> _Cows = new List<Cow>();
        private List<Dog> _Dogs = new List<Dog>();
        private List<Cat> _Cats = new List<Cat>();
        private List<Pig> _Pigs = new List<Pig>();
        private List<Sheep> _Sheep = new List<Sheep>();

        public List<Cow> Cows { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Cat> Cats { get; set; }
        public List<Pig> Pigs { get; set; }
        public List<Sheep> Sheep { get; set; }

        public Group()
        {

        }
        public void AddNew(string Animal, string name, int age)
        {
            if (Animal.Equals("Cow"))
            {
                Cows.Add(new Cow(name, age));
            }
            if (Animal.Equals("Dog"))
            {
                Dogs.Add(new Dog(name, age));
            }
            if (Animal.Equals("Cat"))
            {
                Cats.Add(new Cat(name, age));
            }
            if (Animal.Equals("Pig"))
            {
                Pigs.Add(new Pig(name, age));
            }
            if (Animal.Equals("Sheep"))
            {
                Sheep.Add(new Sheep(name, age));
            }
        }

        public string DogTalk()
        {
            return new Dog().Talk();
        }

        public string CowTalk()
        {
            return new Cow().Talk();
        }

        public string CatTalk()
        {
            return new Cat().Talk();
        }

        public string PigTalk()
        {
            return new Pig().Talk();
        }

        public string SheepTalk()
        {
            return new Sheep().Talk();
        }

        public void Show()
        {
            Console.WriteLine("--Cows--");
            foreach (Cow cow in Cows)
                Console.WriteLine("Name -> " + cow.Name + "   Age -> " + cow.Age);
            Console.WriteLine("--Dogs--");
            foreach (Dog dog in Dogs)
                Console.WriteLine("Name -> " + dog.Name + "   Age -> " + dog.Age);
            Console.WriteLine("--Cats--");
            foreach (Cat cat in Cats)
                Console.WriteLine("Name -> " + cat.Name + "   Age -> " + cat.Age);
            Console.WriteLine("--Pigs--");
            foreach (Pig pig in Pigs)
                Console.WriteLine("Name -> " + pig.Name + "   Age -> " + pig.Age);
            Console.WriteLine("--Sheep--");
            foreach (Sheep sheep in Sheep)
                Console.WriteLine("Name -> " + sheep.Name + "   Age -> " + sheep.Age);
        }

        public void ShowCows()
        {
            foreach (Cow cow in Cows)
                Console.WriteLine("Name -> " + cow.Name + "   Age -> " + cow.Age);
        }

        public void ShowDogs()
        {
            foreach (Dog dog in Dogs)
                Console.WriteLine("Name -> " + dog.Name + "   Age -> " + dog.Age);
        }

        public void ShowCats()
        {
            foreach (Cat cat in Cats)
                Console.WriteLine("Name -> " + cat.Name + "   Age -> " + cat.Age);
        }

        public void ShowPigs()
        {
            foreach (Pig pig in Pigs)
                Console.WriteLine("Name -> " + pig.Name + "   Age -> " + pig.Age);
        }

        public void ShowSheep()
        {
            foreach (Sheep sheep in Sheep)
                Console.WriteLine("Name -> " + sheep.Name + "   Age -> " + sheep.Age);
        }
    }
}
