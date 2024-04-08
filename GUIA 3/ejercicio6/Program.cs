/* Hacer un programa para ingresar por teclado la longitud de los tres lados de un triángulo y
que luego determine e informe con un cartel aclaratorio a qué tipo de triángulo corresponde:
a. Equilátero: cuando los tres lados sean iguales.
b. Isósceles: cuando dos de los tres lados sean iguales.
c. Escaleno: cuando todos los lados sean distintos  */

int lado1, lado2, lado3;
Console.WriteLine("INGRESE LA LONG. DEL PRIMER LADO : ");
lado1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE LA LONG. DEL SEGUNDO LADO : ");
lado2 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE LA LONG. DEL TERCER LADO : ");
lado3 = int.Parse(Console.ReadLine());

if(lado1==lado2 && lado1==lado3)
   Console.WriteLine("EL TRIÁNGULO ES EQUILÁTERO");
else if (lado1 ==lado2 || lado1==lado3 || lado2 ==lado3)
   Console.WriteLine("EL TRIÁNGULO ES ISÓSCELES ");
else 
   Console.WriteLine("EL TRIÁNGULO ES ESCALENO ");
   
