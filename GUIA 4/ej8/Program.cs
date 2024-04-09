/* Hacer un programa que solicite 20 números y luego mostrar por pantalla el menor de ellos y
la posición en la que fue encontrado   */

int num, menor=0, pos=0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("INGRESE UN NRO : ");
    num = int.Parse(Console.ReadLine());
    if(i==0)
    {
        menor= num;
        pos =i;
    }

    if(num<menor)
    {
        menor= num;
        pos= i;
    }
}
Console.WriteLine("EL MENOR NRO INGRESADO ES : "+menor);
Console.WriteLine("EN LA POSISCIÓN : "+pos);

