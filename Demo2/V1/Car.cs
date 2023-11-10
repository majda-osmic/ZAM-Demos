namespace Demo2.V1
{
  
    public class Car
    {
        public string Model { get; protected set; }
        public string Brand { get; protected set; }

        public string Color { get; protected set; }


        public Car(string model, string brand, string color)
        {
            Model = model;
            Brand = brand;            Color = color;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}");
        }
    }

}
