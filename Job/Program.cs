using Job;

Process.Welcome();

string? name = Process.GetName();

(string title, decimal salary) = Process.GetJob();

Process.Response(name, title, salary);

Process.End();