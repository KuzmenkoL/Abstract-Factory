using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fab
{
    class Wolf : AbstractAnimal
    {
        public override void Sound()
        {
            Console.WriteLine("Волк воет.");
        }
        public override string Name => "Волк";

    }
}
