namespace FoodChoice
{
    public class Process
    {
        public static void Welcome()
        {
            Console.WriteLine("Food Choice");
            Console.WriteLine("-----------");
            Console.WriteLine();
        }

        public static string? GetFood()
        {
            Console.Write("Enter your food of choice: ");
            string? output = Console.ReadLine();

            return output;
        }

        public static void Response(string? food)
        {
            if (string.IsNullOrEmpty(food))
            {
                food = "Nothing";
            }
            Console.WriteLine($"{food} is an interesting choice!");
            Console.WriteLine("Just remember that balance is key.");
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
