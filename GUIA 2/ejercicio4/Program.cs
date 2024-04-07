/* Hacer un	programa para ingresar un número y luego se	emita un cartel	por	pantalla “Positivo”
si el número es	mayor a	cero,“Negativo” si el número es menor a	cero o “Cero” si el
número es igual	a cero.*/


int num ; 
Console.WriteLine("INGRESE UN NÚMERO : ");
num = int.Parse(Console.ReadLine());
Console.WriteLine("");

if(num<0)
   Console.WriteLine("EL NRO ES NEGATIVO ");
else if (num ==0)
   Console.WriteLine("EL NRO ES 0 ");
else 
   Console.WriteLine("EL NRO ES POSITIVO ");

Console.WriteLine("");
