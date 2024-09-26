// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese la base");
decimal base1 = decimal.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura: ");
decimal altura1 = decimal.Parse(Console.ReadLine());

Console.WriteLine("El perimetro es: " + (2 * (base1 + altura1)));

Console.WriteLine("El area es: " + (base1 * altura1));