/* . Hacer un programa para ingresar 10 números y luego calcule y emita el mayor de los primos
de la lista. En caso de no haber ningún número primo, deberá aclararlo con un cartel. */
internal class Program
{
    private static void Main(string[] args)
    {
        int num,contador=0, mayor =0;
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("INGRESE UN NRO : ");
            num= int.Parse(Console.ReadLine());
            for (int x = 1; x <= num; x++)
            {
                if(num %x==0 )
                   contador++;
            }
            if(contador ==2)
            {
                if(num> mayor )
                   mayor= num;
            }
            contador=0;
            

        }
        if(mayor== 0)
           Console.WriteLine("NO SE INGRESARON NROS PRIMOS ");
        else
           Console.WriteLine("EL MAYOR PRIMO INGRESADO ES : "+mayor);
    }
}