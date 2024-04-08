/*. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de 
los dos primeros es mayor al producto del segundo con el tercero */

int n1, n2 ,n3;
Console.WriteLine("INGRESE EL PRIMER NRO : ");
n1 = int.Parse(Console.ReadLine());
Console .WriteLine("INGRESE EL SEGUNDO NRO : ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL TERCER NRO : ");
n3 = int.Parse(Console.ReadLine());

if((n1+n2)>(n2*n3))
   Console.WriteLine("LA SUMA DE LOS PRIMEROS DOS ES MAYOR AL PRODUCTO DEL SEGUNDO Y EL TERCERO");
   Console.WriteLine("SUMA : "+(n1+n2)+" PRODUCTO : "+(n2*n3));

