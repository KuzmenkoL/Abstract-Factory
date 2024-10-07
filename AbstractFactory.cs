using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fab
{
    abstract class AbstractFactory
    {
        public abstract AbstractAnimal CreateAnimal();
        public abstract AbstractHabitat CreateHabitat();
    }
}
