/* Hacer un programa para ingresar por teclado los metros cuadrados totales	de un predio y los metros
 cuadrados cubiertos; luego	calcular y mostrar por pantalla	el porcentaje de metros	cuadrados cubiertos
 y el porcentaje de	metros cuadrados descubiertos.*/

int metrosTotales , metrosCubiertos;
int porCubiertos , porDescubiertos;

Console.WriteLine("INGRESE LOS METROS CUADRADOS TOTALES DEL PREDIO : ");
metrosTotales = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE LOS METROS  CUADRADOS CUBIERTOS : ");
metrosCubiertos = int.Parse(Console.ReadLine());
porCubiertos =  (metrosCubiertos * 100)/ metrosTotales;
porDescubiertos = 100 - porCubiertos;
Console.WriteLine(" EL PORCENTAJE DE METROS CUBIEROS ES DE : "+porCubiertos+" % ");
Console.WriteLine("EL PORCENTAJE DE METROS DESCUBIERTOS ES DE "+porDescubiertos+" % ");