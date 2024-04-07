/* Una casa	de computación paga	a sus empleados	un sueldo fijo de ARS15000 más una comisión	del	5% sobre
el total facturado por cada	empleado. Hacer	un programa	para ingresar el total facturado por un	empleado
y que luego	calcule	y emita	por	pantalla el	sueldo total a cobrar por el mismo */

int totalFacturado, sueldo ;
Console.WriteLine("INGRESE EL TOTAL FACTURADO : ");
totalFacturado = int.Parse(Console.ReadLine());
sueldo = 15000 + (totalFacturado * 5 /100);
Console.WriteLine("EL SUELDO A COBRAR ES DE : "+ sueldo );
