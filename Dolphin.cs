using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fab
{
    class Dolphin : AbstractAnimal
    {
        public override void Sound()
        {
            Console.WriteLine("Дельфин щебечет.");
        }
        public override string Name => "Дельфин";

    }
}
