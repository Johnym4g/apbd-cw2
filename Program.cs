Console.WriteLine("Enter numbers separated by spaces (e.g. 1 5 10):");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Error: Input cannot be empty! Please provide some numbers.");
    return;
}

double CalculateAvarage(int[] numbers)
{
    return numbers.Average();
}
Console.WriteLine($"Avarage: {CalculateAvarage(input.Split(' ').Select(int.Parse).ToArray())}");