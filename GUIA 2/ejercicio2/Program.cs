/* Hacer un	programa para ingresar dos números distintos y luego se	muestre	por	pantalla el
menor de ellos. */

int num1 , num2 ;
Console.WriteLine("INGRESE EL PRIMER NRO : ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NRO : ");
num2 = int.Parse(Console.ReadLine());
if (num1<num2)
   Console.WriteLine("EL MENOR ES EL NRO : "+num1);
else 
   Console.WriteLine("EL MENOR ES EL NRO : "+num2);

