namespace DemoGenericsCollections
{

    public interface ITest
    {

    }

    public class GenericClass<T> where T : ITest
    {
        private readonly T _value;

        public GenericClass(T value)
        {
            _value = value;
        }

        public T GetObject => _value;


    }



    public class Person
    {
        public string FirstName { get; init; }

        public string LastName { get; init; }
    }

    internal class Program
    {


        static void PrintPersonName(Person person)
        {
            string name = person?.Name ?? "Unknown";

            //if(person == null)
            //{
            //    name = "Unknown";
            //}
            //else
            //{
            //    name = person.Name;
            //}

            Console.WriteLine("The person is " + name);
        }


        static void Main(string[] args)
        {

            var person = new Person()
            {
                FirstName = "TESS"
            };




            int day = 4;

            string dayName = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 or 4 or 5 => "Almost weekend",
            };
            Console.WriteLine(dayName);



            PrintPersonName(new Person() { FirstName = "Alice" });

            PrintPersonName(null);





            var text = "My text";
            var number = 0;



            var ageData = new Dictionary<string, int>()
            {
                { "Tom", 45}
            };

            ageData.Add("Alice", 25);


            foreach (string key in ageData.Keys)
            {

            }

            foreach (int value in ageData.Values)
            {

            }

            if (ageData.ContainsKey("Tom"))
            {

            }

            if (ageData.ContainsValue(45))
            {

            }


            List<string> booksToRead = new List<string>()
            {
                "Alice in Wonderland",
                "To Kill a Mocking Bird",
                "1984",
                "The Shining"
            };

            string book = Console.ReadLine();

            booksToRead.Add(book);
            booksToRead.Remove("1984");

            string _5thBook = booksToRead[5];

            int indexOf1984 = booksToRead.IndexOf("1984");

            if (booksToRead.Contains("The Shining"))
            {

            }





            int? test = null;

            if (test.HasValue)
            {
                Console.WriteLine($"{test.Value}");
            }
            else
            {
                Console.WriteLine("Test is null");
            }

            test = 5;
        }

        public static void DoSomething(IEnumerable<string> text)
        {
            foreach (string item in text)
            {

            }
        }
    }
}