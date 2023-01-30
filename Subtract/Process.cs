namespace Subtract
{
    public class Process
    {
        public static void Welcome()
        {
            Console.WriteLine("Substract");
            Console.WriteLine("---------");
            Console.WriteLine();
        }

        public static double[] GetNumbers()
        {
            Console.Write("Enter 1st number: ");
            double.TryParse(Console.ReadLine(), out double n1);

            Console.Write("Enter 2ns number: ");
            double.TryParse(Console.ReadLine(), out double n2);

            double[] output = new double[] { n1, n2 };

            return output;
        }

        public static double Compute(double[] numbers)
        {
            return numbers[0] - numbers[1];
        }

        public static void Response(double[] numbers, double result)
        {
            Console.WriteLine($"{numbers[0]} - {numbers[1]} = {result}");
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
