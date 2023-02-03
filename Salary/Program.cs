using Salary;

Process.Welcome();

string? name = Process.GetName();

(DateOnly payDate, decimal salary) = Process.GetSalary();

Process.Response(name, payDate, salary);

Process.End();