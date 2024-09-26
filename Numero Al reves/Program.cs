// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite los numeros");

int numero = int.Parse(Console.ReadLine());

int resultado;
int revertir;
int revertir2;

revertir = (numero % 10); 
revertir2 = numero / 10;
resultado = (revertir * 10) + revertir2;

System.Console.WriteLine("Su numero al reves es: " + resultado);