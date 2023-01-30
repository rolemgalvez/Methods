namespace Multiply
{
    public class Process
    {
        public static void Welcome()
        {
            Console.WriteLine("Multiply");
            Console.WriteLine("--------");
            Console.WriteLine();
        }

        public static double[] GetNumbers()
        {
            Console.Write("Enter 1st number: ");
            double.TryParse(Console.ReadLine(), out double n1);

            Console.Write("Enter 2nd number: ");
            double.TryParse(Console.ReadLine(), out double n2);

            double[] output = new double[] { n1, n2 };

            return output;
        }
    }
}
