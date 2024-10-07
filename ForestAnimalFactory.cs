using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fab
{
    // Фабрика для лесных животных
    class ForestAnimalFactory : AbstractFactory
    {
        public override AbstractAnimal CreateAnimal()
        {
            return new Wolf();
        }
        public override AbstractHabitat CreateHabitat()
        {
            return new Forest();
        }
    }
}
