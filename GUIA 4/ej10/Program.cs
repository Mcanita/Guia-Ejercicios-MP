/* . Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los
 números pares y el mínimo de los números impares. */
internal class Program
{
    private static void Main(string[] args)
    {
        int num, max=0, min=0, cp=0, ci=0;

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("INGRESE UN NRO: ");
            num= int.Parse(Console.ReadLine());

            if(num%2 ==0)
            {
                cp++;
                if(cp==1)
                    max= num;

                else if(num>max)
                    max= num;

            }
            else
            {
                ci++;
                if(ci==1)
                   min= num;
                else if(num<min)
                   min= num;

            }
        }
        Console.WriteLine("el mayor nro par es : "+max);
        Console.WriteLine("EL MENOR DE LOS IMPARES ES : "+min);
        
    }
}