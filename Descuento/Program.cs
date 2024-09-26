
Console.WriteLine("Ingrese el monto del articulo: ");

double monto = double.Parse(Console.ReadLine());


double descuento = (monto * 0.15 );

double preciofinal = monto - descuento;


System.Console.WriteLine("El precio del articulo es: " + monto);
System.Console.WriteLine("El descuento es de: " + descuento);
System.Console.WriteLine("Su precio despues del descuento es: " + preciofinal );