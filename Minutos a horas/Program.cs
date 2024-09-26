// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite los minutos: ");

int minutos = int.Parse(Console.ReadLine());
int catidadHora = minutos / 60;
minutos = minutos % 60;
System.Console.WriteLine("Sus horas son: " + catidadHora+" y "+minutos + " minutos ");