/* Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los
mismos se encuentran ordenados de forma decreciente */

int n1, n2, n3, n4;

Console.WriteLine("INGRESE EL PRIMER NRO : ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NRO : ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL TERCER NRO : ");
n3 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL CUARTO NRO : ");
n4 = int.Parse(Console.ReadLine());

if(n1<n2 && n2<n3 && n3<n4)
   Console.WriteLine("LOS NROS ESTAN EN FORMA CRECIENTE ");
else if (n1>n2 &&  n2>n3 && n3>n4)
   Console.WriteLine("LOS NROS ESTAN DE FORMA DECRECIENTE ");
else 
   Console.WriteLine("LOS NROS ESTAN MEZCLADOS ");
