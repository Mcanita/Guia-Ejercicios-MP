/* Hacer un programa que solicite 10 números y luego mostrar por pantalla el
máximo de ellos y la posición en la que fue ingresado. */

int num, pos=0, max=0;
 for (int i = 0; i < 10; i++)
 {
    Console.WriteLine("INGRESE 10 NROS : ");
    num = int.Parse(Console.ReadLine());
    if(i==0)
    {
        max= num;
        pos= i;
    }
    else
    {
        if(num>max)
        {
            max= num;
            pos= i;
        }
    }
   
 }
  Console.WriteLine("EL MAYOR NRO INGRESADO ES : "+max);
  Console.WriteLine("EN LA POSICION : "+(pos+1));
