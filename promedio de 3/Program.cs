// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite 3 numeros");

double num1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Digite otro numero: ");
double num2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Digite otro numero mas: ");
double num3 = double.Parse(Console.ReadLine());

Console.WriteLine("Su promedio es: " + ( (num1 + num2 + num3) / 3));
