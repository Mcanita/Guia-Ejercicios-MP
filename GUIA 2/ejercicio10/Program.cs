/* Hacer un	programa para ingresar cuatro números y	luego mostrar por pantalla cuáles son
mayores	a 100. */

int n1, n2, n3, n4;
Console.WriteLine("INGRESE EL PRIMER NRO : ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NRO : ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL TERCER NRO : ");
n3 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL CUARTO NRO : ");
n4 = int.Parse(Console.ReadLine());

if(n1>100)
  Console.WriteLine("EL NRO "+n1+" ES MAYOR A 100 ");
if(n2>100)
  Console.WriteLine("EL NRO "+n2+" ES MAYOR A 100 ");
if(n3>100)
  Console.WriteLine("EL NRO "+n3+" ES MAYOR A 100 ");
if(n4>100)
  Console.WriteLine("EL NRO "+n4+" ES MAYOR A 100 ");
