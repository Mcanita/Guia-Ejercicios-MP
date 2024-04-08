/* Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si
son todos iguales entre sí, caso contrario, no emitir nada */

int n1, n2, n3, n4;

Console.WriteLine("INGRESE EL PRIMER NRO : ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NRO : ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL TERCER NRO : ");
n3 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL CUARTO NRO : ");
n4 = int.Parse(Console.ReadLine());

if(n1==n2 && n1==n3 && n1==n4)
   Console.WriteLine("LOS CUATRO NROS SON IGUALES ");

