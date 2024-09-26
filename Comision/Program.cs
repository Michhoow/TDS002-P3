/* 
1 Un vendedor recibe un sueldo base 
2 mas un 10% extra por comisión de sus ventas. 

El desea saber cuanto recibirá a fin de mes por concepto de comisión y por concepto 
de salario total. 


Debe ingresar el salario del vendedor, monto vendido, realizar el 
calculo y mostrar los resultados*/

System.Console.WriteLine("Ingrese su sueldo: ");

double sueldo = double.Parse(Console.ReadLine());
System.Console.WriteLine("Ingrese el monte de las ventas de este mes: ");

double ventas = double.Parse(Console.ReadLine());


double comision = (ventas * 10) / 100;

double salariototal = sueldo + comision;

System.Console.WriteLine("Su comision de este mes es de: " + comision);
System.Console.WriteLine("Su sueldo total de este mes es de: " + salariototal);