namespace Demo2.V2
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
            base.DisplayBaseInfo();
            Console.WriteLine($"Trunk Capacity: {TrunkCapacity} l");
        }
    }
}
