using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.V3
{
    public class Animal : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("I am drawing an email");
        }

        public virtual void Reproduce()
        {
            Console.WriteLine("We have animal babies");
        }
    }

    public class Dog : Animal
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

    public class Bird : Animal
    {
        public override void Reproduce() 
        {
            Console.WriteLine("We have HATCHLINGS");
        }
    }
}
