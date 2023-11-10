namespace Demo2.V1
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


        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}");
        }

    }

}
