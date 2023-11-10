using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.V3
{
    internal class Animal
    {
        public virtual void Reproduce()
        {
            Console.WriteLine("We have animal babies");
        }
    }

    internal class Dog : Animal
    {
        public override void Reproduce() 
        {
            Console.WriteLine("We have PUPPIES");

        }

        public void Bark()
        {
            Console.WriteLine("WOOF, WOOF");
        }
    }

    internal class Bird : Animal
    {
        public override void Reproduce() 
        {
            Console.WriteLine("We have HATCHLINGS");
        }
    }
}
