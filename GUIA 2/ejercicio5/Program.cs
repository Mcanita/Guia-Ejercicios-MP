/*Hacer	un programa	para ingresar un número	y mostrar por pantalla un cartel aclaratorio si	el
mismo es PAR o IMPAR.*/

int num ; 
Console.WriteLine("INGRESE UN NÚMERO : ");
num = int.Parse(Console.ReadLine());

if(num % 2 ==0)
  Console.WriteLine("EL NRO ES PAR ");
else 
  Console.WriteLine("EL NRO ES IMPAR ");

Console.WriteLine("");
