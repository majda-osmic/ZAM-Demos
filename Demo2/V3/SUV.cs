namespace Demo2.V3
{
    public class SUV : Car
    {
        public bool AllWheelDrive { get; protected set; }

        public SUV(string model, string brand, bool allWheelDrive) : base(model, brand)
        {
            AllWheelDrive = allWheelDrive;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"All wheel drive: {AllWheelDrive}");
        }

    }
}
