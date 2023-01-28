using FoodChoice;

Process.Welcome();

string? food = Process.GetFood();

Process.Response(food);

Process.End();