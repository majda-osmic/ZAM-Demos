using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.V2
{
    public abstract class Car
    {
        public string Model { get; protected set; }
        public string Brand { get; protected set; }


        public Car(string model, string brand)
        {
            Model = model;
            Brand = brand;
        }

        public abstract void DisplayInfo();

        protected void DisplayBaseInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}");
        }


    }
}
