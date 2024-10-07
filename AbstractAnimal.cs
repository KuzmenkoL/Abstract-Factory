using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fab
{
    // Абстрактный класс животного
    abstract class AbstractAnimal
    {
        public abstract void Sound();
        public abstract string Name { get; }
    }
}
