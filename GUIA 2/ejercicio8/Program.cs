/* Hacer un	programa para ingresar cuatro números distintos	y luego	mostrar	por	pantalla 
el menor de	ellos */

int n1, n2, n3, n4;
Console.WriteLine("INGRESE EL PRIMER NRO : ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NRO : ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL TERCER NRO : ");
n3 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL CUARTO NRO : ");
n4 = int.Parse(Console.ReadLine());

if(n1<n2 && n1<n3 && n1<n4)
   Console.WriteLine("EL NRO : "+n1+" ES EL MENOR ");
else if(n2<n1 && n2<n3 && n2<n4)
   Console.WriteLine("EL NRO : "+n2+" ES EL MENOR ");
else if(n3<n1 && n3<n2 && n3<n4)
   Console.WriteLine("EL NRO : "+n3+" ES EL MENOR ");
else 
   Console.WriteLine("EL NRO : "+n4+" ES EL MENOR ");
   
   
