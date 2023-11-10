namespace Demo2.V3
{
    public class Sedan : Car
    {
        public int TrunkCapacity { get; protected set; }
        public Sedan(string model, string brand, int trunkCapacity) : base(model, brand)
        {
            TrunkCapacity = trunkCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Trunk Capacity: {TrunkCapacity} l");
        }
    }
}
