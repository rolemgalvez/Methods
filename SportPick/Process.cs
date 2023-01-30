namespace SportPick
{
    public class Process
    {
        public static void Welcome()
        {
            Console.WriteLine("Sport Pick");
            Console.WriteLine("----------");
            Console.WriteLine();
        }

        public static string? GetSport()
        {
            Console.Write("Enter your favorite sport: ");
            string? output = Console.ReadLine();

            return output;
        }

        public static void Response(string? sport)
        {
            if (string.IsNullOrEmpty(sport))
            {
                sport = "something";
            }
            Console.WriteLine($"Hope {sport} makes you have fun!");
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
