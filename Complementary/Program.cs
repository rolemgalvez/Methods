using Complementary;

Process.Welcome();

string name = Process.GetName();

(string color1, string color2) = Process.GetColors();

Process.Response(name, color1, color2);

//End