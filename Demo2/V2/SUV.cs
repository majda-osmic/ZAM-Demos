namespace Demo2.V2
{
    public class SUV : Car
    {
        public bool AllWheelDrive { get; set; }

        public SUV(string model, string brand, bool allWheelDrive) : base(model, brand)
        {
            AllWheelDrive = allWheelDrive;
        }

        public override void DisplayInfo()
        {
            base.DisplayBaseInfo();
            Console.WriteLine($"All wheel drive: {AllWheelDrive}");
        }
    }
}
