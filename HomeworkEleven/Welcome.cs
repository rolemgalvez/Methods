namespace HomeworkEleven
{
    public class Welcome
    {
        public static void Header()
        {
            Console.WriteLine("Homework Eleven");
            Console.WriteLine("---------------");
            Console.WriteLine();
        }

        public static (string name, string alias) GetName()
        {
            Console.Write("Enter name: ");
            string? name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                name = "nobody";
            }

            (string, string) output = (name, "user");

            return output;
        }
    }
}
