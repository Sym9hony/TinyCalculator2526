Console.WriteLine("=== Tiny Calculator ===");

Console.Write("Summand 1: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Summand 2: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"{a} + {b} = {a + b}");



