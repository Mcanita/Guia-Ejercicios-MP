/* Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos
por pantalla. Solo se debe emitir UN valor por pantalla. */

int num, mayor=0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("INGRESE 10 NROS : ");
    num = int.Parse(Console.ReadLine());
    if(i==0)
      mayor = num;
    else
    {
        if( num > mayor)
           mayor = num;
    }
      
}
Console.WriteLine("EL MAYOR NRO INGRESADO ES : "+mayor);
