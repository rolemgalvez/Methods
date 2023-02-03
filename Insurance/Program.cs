using Insurance;

Process.Welcome();

string name = Process.GetName();

(_, string healthInsurance) = Process.GetInsurance();

Process.Response(name, healthInsurance);

Process.End();