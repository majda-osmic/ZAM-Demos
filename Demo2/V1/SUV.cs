namespace Demo2.V1
{
    public class SUV : Car
    {
        public bool AllWheelDrive { get; set; }
        public SUV(string model, string brand, bool allWheelDrive) : base(model, brand)
        {
            AllWheelDrive = allWheelDrive;
        }

        public new void DisplayInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}");
            Console.WriteLine($"All wheel drive: {AllWheelDrive}");
        }
    }

}
