namespace Salary
{
    public class Process
    {
        public static void Welcome()
        {
            Console.WriteLine("Salary");
            Console.WriteLine("------");
            Console.WriteLine();
        }

        public static string? GetName()
        {
            Console.Write("Enter name: ");
            string? output = Console.ReadLine();

            return output;
        }

        public static (DateOnly payDate, decimal salary) GetSalary()
        {
            DateOnly payDate = DateOnly.FromDateTime(DateTime.Now);
            decimal salary = 18500;

            return (payDate, salary);
        }

        public static void Response(string? name, DateOnly date, decimal salary)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "nobody";
            }

            Console.WriteLine();
            Console.WriteLine($"Hi {name}, sample expectation is...");
            Console.WriteLine($"Date   : {date}");
            Console.WriteLine($"Salary : {salary.ToString("N")}");
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("End of program.");
            Console.ReadLine();
        }
    }
}
