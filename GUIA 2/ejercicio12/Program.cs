/* Hacer un programa para ingresar un valor	que	estará expresado en	minutos. Si	los	minutos
superan	los 60,	pasar el valor a horas,	de lo contrario	dejarlo	en minutos.	Mostrar	el
resultado en pantalla aclarando	si se muestran minutos u horas.  */

int minutos, horas ,resto ;
Console.WriteLine("INGRESE LA CANTIDAD DE MINUTOS : ");
minutos = int.Parse(Console.ReadLine());
if(minutos>60)
{
    horas = minutos /60;
    resto = minutos %60;
    Console.WriteLine("EQUIVALE A "+horas+" HORAS Y "+resto+" MINUTOS ");
}
else 
{
    Console.WriteLine("SON "+minutos+" MINUTOS");
}
 
