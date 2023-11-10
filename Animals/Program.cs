using Animals.V1;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //V1.Animal dog = new V1.Dog();
            //dog.Reproduce();

            //V1.Animal animal = new V1.Animal();

            //V2.Animal animal2 = new V2.Dog();
            //animal2.Reproduce();

            //V3.Animal animal3 = new V3.Animal();
            //animal3.Reproduce();

            //V3.Animal dog3 = new V3.Dog();
            //dog3.Reproduce();

            MakeThemReproduce(new V3.Dog());
            MakeThemReproduce(new V3.Bird());
            MakeThemReproduce(new V3.Animal());
            MakeThemReproduce(new V3.Bird());
            MakeThemReproduce(new V3.Dog());

            //MakeThemReproduce(new V1.Dog());
            //MakeThemReproduce(new V1.Bird());
            //MakeThemReproduce(new V1.Animal());
            //MakeThemReproduce(new V1.Bird());
            //MakeThemReproduce(new V1.Dog());

        }

        public static void MakeThemReproduce(V3.Animal animal)
        {
            if(animal is V3.Dog dog)
            {
                dog.Bark();
            }

            animal.Reproduce();
        }

        public static void MakeThemReproduce(V1.Animal animal)
        {
            animal.Reproduce();
        }
    }
}