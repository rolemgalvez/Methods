namespace Insurance
{
    public class Process
    {
        public static void Welcome()
        {
            Console.WriteLine("Insurance");
            Console.WriteLine("---------");
            Console.WriteLine();
        }

        public static string GetName()
        {
            Console.Write("Enter your name: ");
            string? output = Console.ReadLine();

            if (string.IsNullOrEmpty(output))
            {
                output = "nobody";
            }

            return output;
        }

        public static (string life, string health) GetInsurance()
        {
            return ("Pru Life UK", "Intellicare");
        }

        public static void Response(string name, string insurance)
        {
            Console.WriteLine();
            Console.WriteLine($"Hi there {name}!");
            Console.WriteLine($"We have {insurance} as health insurance.");
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
