using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.V3
{

    public class Car
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
    }
}
