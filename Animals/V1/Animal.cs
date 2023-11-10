using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.V1
{
    internal class Animal
    {
        public void Reproduce()
        {
            Console.WriteLine("We have baby animals");
        }
    }

    internal class Bird : Animal
    {
        public new void Reproduce()
        {
            Console.WriteLine("We have HATCHLINGS");
        }
    }
}
