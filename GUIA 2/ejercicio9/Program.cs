/*Hacer	un programa para ingresar cinco	números	distintos y	luego mostrar por pantalla el
mayor y	el menor de	ellos. */

int n1, n2, n3, n4, n5;
Console.WriteLine("INGRESE EL PRIMER NRO : ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NRO : ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL TERCER NRO : ");
n3 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL CUARTO NRO : ");
n4 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL QUINTO NRO : ");
n5 = int.Parse(Console.ReadLine());

if(n1<n2 && n1<n3 && n1<n4 && n1<n5)
  Console.WriteLine("EL MENOR NRO ES EL : "+n1);
else if(n2<n1 && n2<n3 && n2<n4 && n2<n5)
  Console.WriteLine("EL MENOR NRO ES EL : "+n2);
else if(n3<n1 && n3<n2 && n3<n4 && n3<n5)
  Console.WriteLine("EL MENOR NRO ES EL : "+n3);
else if(n4<n1 && n4<n2 && n4<n3 && n4<n5)
  Console.WriteLine("EL MENOR NRO ES EL : "+n4);
else 
  Console.WriteLine("EL MENOR NRO ES EL : "+n5);


if(n1>n2 && n1>n3 && n1>n4 && n1>n5)
  Console.WriteLine("EL MAYOR NRO ES EL : "+n1);
else if(n2>n1 && n2>n3 && n2>n4 && n2>n5)
  Console.WriteLine("EL MAYOR NRO ES EL : "+n2);
else if(n3>n1 && n3>n2 && n3>n4 && n3>n5)
  Console.WriteLine("EL MAYOR NRO ES EL : "+n3);
else if(n4>n1 && n4>n2 && n4>n3 && n4>n5)
  Console.WriteLine("EL MAYOR NRO ES EL : "+n4);
else 
  Console.WriteLine("EL MAYOR NRO ES EL : "+n5);
