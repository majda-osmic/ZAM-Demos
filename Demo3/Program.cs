namespace Demo3
{

    public delegate string PerformCalculation(double x, double y);

    internal class Program
    {
        static void Main(string[] args)
        {
            DoSomething((a, b) => $"{a * b}");


            PerformCalculation calculate;

            do
            {
                Console.WriteLine("Do you want to: ");
                Console.WriteLine("a - add");
                Console.WriteLine("s - subtract");

                string input = Console.ReadLine();

                if (input == "a")
                {
                    calculate = (x, y) => $"{x + y}";
                }
                else if (input == "s")
                {
                    calculate = (x, y) => $"{x - y}";
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                    continue;
                }

                Console.WriteLine("Please type your numbers: ");


                double operand1 = GetOperand("1st: ");
                double operand2 = GetOperand("2nd: ");

                string result = calculate(operand1, operand2);
                Console.WriteLine("Result is " + result);


            } while (Console.ReadKey(true).Key != ConsoleKey.F12);


        }


        public static double GetOperand(string prompt)
        {

            bool hasValidInput = false;
            double operand;
            do
            {

                Console.Write(prompt);
                string input1 = Console.ReadLine();

                if (!double.TryParse(input1, out operand))
                {
                    Console.WriteLine("Invalid input, please type in a number!");
                }
                else
                {
                    hasValidInput = true;
                }

            } while (hasValidInput != true);

            return operand;

        }

        public static void DoSomething(PerformCalculation calc)
        {
            calc(4.3, 5.6);
        }
    }
}