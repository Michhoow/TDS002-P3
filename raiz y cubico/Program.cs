System.Console.WriteLine("Digite un numero");

double num1 = double.Parse(Console.ReadLine());


double cuadrado, cubo;


cuadrado = num1 * num1;

cubo = ((num1 * num1) * num1);

System.Console.WriteLine("La raiz cuadrada es: " + cuadrado);
System.Console.WriteLine("La raiz cubica es: " + cubo);