/* Hacer un programa que solicite el ingreso de un número y que luego emita un cartel por
pantalla aclarando si el mismo es múltiplo de 5  */

int num;
Console.WriteLine("INGRESE UN NRO : ");
num = int.Parse(Console.ReadLine());

if(num % 5==0 )
  Console.WriteLine("EL NRO "+num+ " ES MÚLTIPLO DE 5  ");
else
  Console.WriteLine("EL NRO "+num+ " NO ES MÚLTIPLO DE 5  ");
