using Name;

Process.Welcome();

(string firstName, _) = Process.GetName();

Process.Response(firstName);

Process.End();