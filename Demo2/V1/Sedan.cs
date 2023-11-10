namespace Demo2.V1
{
    public class Sedan : Car
    {
        public int TrunkCapacity { get; protected set; }
        public Sedan(string model, string brand, int trunkCapacity) : base(model, brand, "")
        {
            TrunkCapacity = trunkCapacity;
        }

        public new void DisplayInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}");
            Console.WriteLine($"Trunk Capacity: {TrunkCapacity} l");
        }
    }

}
