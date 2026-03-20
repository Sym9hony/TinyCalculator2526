Console.WriteLine("=== Tiny Calculator ===");

Console.Write("Operand 1: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Operand 2: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} * {b} = {a * b}");
if (b == 0)
{ 
    Console.WriteLine($"{a} / {b} = undefied");
}
else
{
    Console.WriteLine($"{a} / {b} = {a / b}");
}




