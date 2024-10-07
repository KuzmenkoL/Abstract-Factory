using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fab
{
    class Client
    {
        private AbstractAnimal animal;
        private AbstractHabitat habitat;

        public Client(AbstractFactory factory)
        {
            animal = factory.CreateAnimal();
            habitat = factory.CreateHabitat();
        }

        public void Print()
        {
            Console.WriteLine($"Животное: {animal.Name}");
            animal.Sound();
            Console.WriteLine($"Место обитания: {habitat.Place}");
        }
    }
}
