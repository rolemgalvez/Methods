using Add;

Process.Welcome();

double[] numbers = Process.GetNumbers();

double result = Process.Compute(numbers);

Process.Response(numbers, result);

Process.End();