namespace User
{
    public class Process
    {
        public static void Welcome()
        {
            Console.WriteLine("User");
            Console.WriteLine("----");
            Console.WriteLine();
        }

        public static string? GetName()
        {
            Console.Write("Enter your name: ");
            string? output = Console.ReadLine();

            return output;
        }

        public static void ShowResult(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "there";
            }

            Console.WriteLine($"Hi {name}, nice to meet you!");
        }

        public static void ProgramEnd()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
