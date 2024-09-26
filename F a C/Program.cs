// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese los grados fahrenheit");

decimal fahrenheit = decimal.Parse(Console.ReadLine());

const decimal celsius = 32;

Console.WriteLine("Su conversion al celsius es: " + ((fahrenheit - celsius) * 5 / 9));

    
