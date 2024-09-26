
Console.WriteLine("Digite un numero: ");


double num1, num2, distancia;
num1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Digite otro numero: ");
num2 = double.Parse(Console.ReadLine()!);

if (num1 <= num2)
{
    distancia = (num1 - num2) * -1;
    System.Console.WriteLine("La distancia es de: " + distancia);
}else
{
    distancia = (num1 - num2) * 1;
    System.Console.WriteLine("La distancia es de: " + distancia);
}