using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fab
{
    // Фабрика для морских животных
    class SeaAnimalFactory : AbstractFactory
    {
        public override AbstractAnimal CreateAnimal()
        {
            return new Dolphin();
        }

        public override AbstractHabitat CreateHabitat()
        {
            return new Ocean();
        }
    }

}
