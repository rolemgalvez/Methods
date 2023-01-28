namespace FavoriteNumber
{
    public class Process
    {
        public static void Welcome()
        {
            Console.WriteLine("Favorite Number");
            Console.WriteLine("---------------");
            Console.WriteLine();
        }

        public static double GetNumber()
        {
            Console.Write("Enter your favorite number: ");
            string? textInput = Console.ReadLine();
            _ = double.TryParse(textInput, out double output);

            return output;
        }

        public static void Response(double number)
        {
            Console.WriteLine($"{number} is my friend's favorite number too!");
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
