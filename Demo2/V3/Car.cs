using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.V3
{

    public class Car : IDrawable
    {
        public string Model { get; protected set; }
        public string Brand { get; protected set; }

        public Car(string model, string brand)
        {
            Model = model;
            Brand = brand;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}");
        }

        public virtual void Draw()
        {
            Console.WriteLine($"I am now drawing a {Brand} {Model}");
        }
    }
}
