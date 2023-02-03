namespace Name
{
    public class Process
    {
        public static void Welcome()
        {
            Console.WriteLine("Name");
            Console.WriteLine("----");
            Console.WriteLine();
        }

        public static (string first, string? last) GetName()
        {
            Console.Write("Enter first name: ");
            string? first = Console.ReadLine();

            Console.Write("Enter last name: ");
            string? last = Console.ReadLine();

            if (string.IsNullOrEmpty(first))
            {
                first = "nobody";
            }

            (string, string?) output = (first, last);

            return output;
        }

        public static void Response(string firstName)
        {
            Console.WriteLine();
            Console.WriteLine("Hi there!");
            Console.WriteLine($"Let us call you {firstName}.");
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
