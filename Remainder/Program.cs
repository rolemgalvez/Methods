using Remainder;

Process.Welcome();

double[] numbers = Process.GetInput();

double result = Process.Compute(numbers);

Process.Response(numbers, result);

Process.End();