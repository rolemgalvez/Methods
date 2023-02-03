namespace Complementary
{
    public class Process
    {
        public static void Welcome()
        {
            Console.WriteLine("Complementary");
            Console.WriteLine("-------------");
            Console.WriteLine();
        }

        public static string GetName()
        {
            Console.Write("Enter name: ");
            string? output = Console.ReadLine();

            if (string.IsNullOrEmpty(output))
            {
                output = "nobody";
            }

            return output;
        }

        public static (string color1, string color2) GetColors()
        {
            return ("Blue", "Yellow");
        }

        public static void Response(string name, string color1, string color2)
        {
            Console.WriteLine();
            Console.WriteLine($"Hi {name}, our suggestion is...");
            Console.WriteLine($"{color1} - {color2}");
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
