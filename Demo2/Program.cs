// See https://aka.ms/new-console-template for more information


using Demo2;
using GeometricObjects;
using Interfaces;
using System.Numerics;

internal class Program
{

    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException() { }
        public EmployeeNotFoundException(string message) : base(message) { }
    }

    private static void Main(string[] args)
    {
        try
        {
            ReadFromFile();
          //  throw new EmployeeNotFoundException("Employee does not exist");
        }
       
        catch (EmployeeNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
      
        




        ////Demo2.V3.Car car = new Demo2.V3.Sedan("Mercedes-Benz", "C-Class", 400);
        ////car.DisplayInfo();

        //IDrawable[] drawables = new IDrawable[]
        //{
        //    new Demo2.V3.Sedan("Mercedes-Benz", "C-Class", 400),
        //    new GraphicCircle(10),
        //    new Demo2.V3.SUV("BMW", "5", true)
        //};

        //DrawAllObjects(drawables);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="FileNotFoundException"></exception>
    public static void ReadFromFile()
    {
        Console.WriteLine("Type a file path: ");
        string path = Console.ReadLine();

        if(File.Exists(path))
        {
            using StreamReader streamReader = new StreamReader(path);
            Console.WriteLine(streamReader.ReadToEnd());
        }
        else
        {
            throw new FileNotFoundException($"File {path} does not exist");
        }



    }

        public static void DrawAllObjects(IDrawable[] allDrawableObjects)
        {
            foreach (IDrawable obj in allDrawableObjects)
            {
                obj.Draw();
            }
        }


    }



//Car redFerrari = new Car();
//redFerrari.MaxSpeed = 500;
//redFerrari.Color = "Red";
//redFerrari.Model = "Ferrari";

//redFerrari.Drive();


//Car blueCar = new Car();
//blueCar.Model = "Volvo";

//for(; ; )
//{
//    break;
//}

//int input;
//do
//{
//    Console.WriteLine("The magic number is: ");
//    input = Convert.ToInt32(Console.ReadLine());

//    if (input == 42)
//    {
//        break;
//    }
//    Console.WriteLine($"No, {input} is not the magic number!");
//} while (true);

//Console.WriteLine("That's right. The magic number is 42");

//int counter = 0; 
//while(counter < 5)
//{
//    Console.WriteLine($"The counter value now is {counter}");
//    counter++;
//}

//int[] elements = { 2, 4, 6, 8 };
//foreach (int item in elements)
//{
//    item = 33;
//    Console.WriteLine(item);
//}


//int[] numbers;
//Console.WriteLine("Type the maximum Array-Index: ");
//numbers = new int[Convert.ToInt32(Console.ReadLine()) + 1];

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = i * i;
//    Console.WriteLine(numbers[i]);
//}
//for(int i = 1; i <= 5; i++)
//{
//    for(int j = 1; j <= 5; j++)
//    {
//        Console.WriteLine($"{i * j}");
//    }
//}


//for (int counter = 0; counter < 10; counter++)
//{
//    if (counter == 3)
//        continue; 
//    Console.WriteLine($"The counter value now is {counter}");
//}



//int[] numbers;
//int size = Convert.ToInt32(Console.ReadLine());
//numbers = new int[size];



//int number = Convert.ToInt32(Console.ReadLine());

//switch(number)

//{
//    case 0: 
//     case 1:
//        Console.WriteLine("The number is 0 or 1");
//        break;
//    default:
//        Console.WriteLine("The number is negative or > 1");
//        break;
//}

//int x, y;

//Console.WriteLine("Type a number: ");
//x = Convert.ToInt32(Console.ReadLine());

//y = x == 0 ? 1 : x;  
//if(x == 0)
//{
//    y = 1;
//}
//else
//{
//    y = x;
//}

//long i = 0; 
//checked
//{
//    int targetInt = (int)i;
//    //......
//    short targetShort = (short)i;
//    //
//    //.....
//}

//int i = 256;
//byte myByte = unchecked((byte)i);
//Console.WriteLine(myByte);

//string text = "123";
//int textInInt = Convert.ToInt32(text);
//Console.WriteLine($"My int is {textInInt}");

//int value = 1;
//bool boolValue = Convert.ToBoolean(value);

//long value1 = 1200;
//int longValue = (int)value1;



//Object myType = "some text";
//myType = 2;
//myType = 9.8;


//bool firstBool = false;
//char firstLetterOfAlphabet = 'A';

//DateTime now = DateTime.UtcNow;

//Console.WriteLine($"DateTime.Now is {DateTime.Now.Millisecond}");
//Console.WriteLine($"DateTime.UtcNow is {DateTime.UtcNow}");

//float value1 = 0.0123456789123456789123456789f;
//double value2 = 0.0123456789123456789123456789d;

//Console.WriteLine("Float value is "+ value1);
//Console.WriteLine("Double value is " + value2);

//Console.WriteLine($"The range of int in c# is between {Int32.MinValue} and {Int32.MaxValue}");

//Console.WriteLine("How old were you when you started talking?");
//char age =  (char) Console.Read();
//Console.WriteLine($"Cool, you were {age} years old when you started talking.");


//Console.Write("Your favourite drink is: ");
//string drink = Console.ReadLine();
//Console.WriteLine($"Great, let's {drink} together after class.");
//Console.ReadLine();



