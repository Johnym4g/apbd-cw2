Console.WriteLine("Enter numbers separated by spaces (e.g. 1 5 10):");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Error: Input cannot be empty! Please provide some numbers.");
    return;
}

int[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
//TODO: check CalculateMin method
Console.WriteLine($"Average: {CalculateAvarage(numbers)}");

Console.WriteLine($"Max value: {CalculateMax(numbers)}");

Console.WriteLine($"Min value: {CalculateMin(numbers)}");
double CalculateAvarage(int[] val)
{
    return val.Average();
}

int CalculateMax(int[] val)
{
    return val.Max();
}

int CalculateMin(int[] val)
{
    return val.Max();
}