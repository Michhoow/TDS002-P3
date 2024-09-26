// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite el valor de A: ");
int resultado;
int A1 = int.Parse(Console.ReadLine());


System.Console.WriteLine("Digite el valor de B");

int B1 = int.Parse(Console.ReadLine());


A1 = A1 + B1;
B1 = A1 - B1;
A1 = A1 - B1;

System.Console.WriteLine($"{A1}{B1}");


