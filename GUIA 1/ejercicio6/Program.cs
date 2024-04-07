/* Hacer un	programa para ingresar por teclado las tres	notas de exámenes de un	alumno y luego calcule y
emita por pantalla el promedio final. */

int nota1 , nota2, nota3;
int promedio ;

Console.WriteLine("INGRESE LA PRIMERA NOTA : ");
nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE LA SEGUNDA NOTA : ");
nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE LA TERCERA  NOTA : ");
nota3 = int.Parse(Console.ReadLine());
promedio = (nota1 + nota2 + nota3 )/3;
Console.WriteLine("EL PROMEDIO ES : "+promedio);

