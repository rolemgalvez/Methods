namespace Hometown
{
    public class Process
    {
        public static void Welcome()
        {
            Console.WriteLine("Hometown");
            Console.WriteLine("--------");
            Console.WriteLine();
        }

        public static string? GetHometown()
        {
            Console.Write("Enter your hometown: ");
            string? output = Console.ReadLine();

            return output;
        }

        public static void Response(string? hometown)
        {
            if (string.IsNullOrEmpty(hometown))
            {
                hometown = "Nothingness";
            }
            Console.WriteLine($"Hope you've enjoyed your time at {hometown}.");
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
