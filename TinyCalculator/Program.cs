Console.WriteLine("=== Tiny Calculator ===");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Operand 1: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Operand 2: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.ResetColor();

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"{a} + {b} = {a + b}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{a} - {b} = {a - b}");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"{a} * {b} = {a * b}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{a} / {b} = {(double)a / b}");
//if (b == 0)
//{ 
//    Console.WriteLine($"{a} / {b} = undefied");
//}
//else
//{
//    Console.WriteLine($"{a} / {b} = {(double)a / b}");
//}
Console.ResetColor();



