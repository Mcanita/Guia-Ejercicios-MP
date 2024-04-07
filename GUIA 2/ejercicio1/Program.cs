/* Hacer un programa para ingresar un número y luego se	emita por pantalla un cartel 
aclaratorio	si	“Es	mayor a	10” o “No es mayor a 10”.*/

int num ; 
Console.WriteLine("INGRESE UN NRO : ");
num = int.Parse(Console.ReadLine());
if (num >10)
    Console.WriteLine("EL NRO ES MAYOR A 10 ");
else
    Console.WriteLine("EL NRO NO ES MAYOR A 10 ");