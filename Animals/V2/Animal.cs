using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.V2
{
    internal abstract class Animal
    {
        public abstract void Reproduce();
    }

    internal class Dog : Animal
    {
        public override void Reproduce()
        {
            Console.WriteLine("We have puppies");
        }
    }
}
