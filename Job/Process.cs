namespace Job
{
    public class Process
    {
        public static void Welcome()
        {
            Console.WriteLine("Job");
            Console.WriteLine("---");
            Console.WriteLine();
        }

        public static string? GetName()
        {
            Console.Write("Enter name: ");
            string? output = Console.ReadLine();

            return output;
        }

        public static (string title, decimal salary) GetJob()
        {
            return ("Technical Support", 18000);
        }

        public static void Response(string? name, string title, decimal salary)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "nobody";
            }

            Console.WriteLine();
            Console.WriteLine($"Hi {name}, the available job is...");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Salary: {salary.ToString("N")}");
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
