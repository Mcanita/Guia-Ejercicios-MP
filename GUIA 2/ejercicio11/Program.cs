/* Hacer un	programa para ingresar cuatro números y	luego mostrar por pantalla cuántos son
menores	a 100  */

int num, cont=0 ;

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("INGRESE UN NRO : ");
    num = int.Parse(Console.ReadLine());
    if(num<100)
       cont ++;

}

Console.WriteLine("HAY "+cont+" NROS MENORES A 100 ");


