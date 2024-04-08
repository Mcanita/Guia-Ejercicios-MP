/*  Hacer un programa que solicite el ingreso de las notas del primer parcial y del segundo
parcial de una alumna de programación. El programa deberá analizar las notas y emitir la
situación de la alumna según la siguiente escala:
a. Si tiene 8 o más en ambos parciales, emitir “aprobación directa”.
b. Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales (se aprueba con 6 o más),
emitir “rinde examen final”.
c. Si tiene menos de 6 en alguno de los dos parciales, emitir “debe recuperar”.
El programa debe emitir solo un cartel, el que corresponda.  */

int nota1, nota2;
Console.WriteLine("INGRESE LA NOTA DEL PRIMER PARCIAL : ");
nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE LA NOTA DEL SEGUNDO PARCIAL : ");
nota2 = int.Parse(Console.ReadLine());

if(nota1 <6 || nota2 <6)
   Console.WriteLine("DEBE RECUPERAR ");
else if ((nota1>=6 && nota1<8) && (nota2>=6 && nota2 <8))
   Console.WriteLine("RINDE EXAMEN FINAL : ");
else 
   Console.WriteLine("APROBACIÓN DIRECTA ");
