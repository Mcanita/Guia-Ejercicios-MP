/*Hacer un programa	para ingresar dos números y	que	luego emita	por	pantalla el	mayor de ellos
o un cartel	aclaratorio	“Son iguales” en el	caso de	que	así sea.
Nota:	los	números	pueden	ser	iguales*/
int num1, num2 ;
Console.WriteLine("INGRESE EL PRIMER NRO : ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO  NRO : ");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("");

if(num1 > num2)
   Console.WriteLine("EL NRO "+ num1+" ES EL MAYOR ");
else if (num1== num2)
   Console.WriteLine("LOS NROS SON IGUALES  ");
else
    Console.WriteLine("EL NRO "+ num2+" ES EL MAYOR ");
   
   
