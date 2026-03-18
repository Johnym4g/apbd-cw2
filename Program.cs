Console.WriteLine("Enter numbers separated by spaces (e.g. 1 5 10):");
string? input = Console.ReadLine();

Console.WriteLine("User entered: " + input);

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Error: Input cannot be empty! Please provide some numbers.");
    return;
}