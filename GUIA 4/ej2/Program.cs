/* Hacer un programa que solicite 20 números y calcule y emita por pantalla cuántos son 
positivos (mayores a cero). Se debe mostrar un solo valor: el conteo final. */
internal class Program
{
    private static void Main(string[] args)
    {
        int num, positivos = 0;
        
        for (int i = 0; i <6; i++)
        {
            Console.WriteLine("INGRESE UN NRO : ");
            num = int.Parse(Console.ReadLine());
            if(num >=0)
               positivos++;
        }
        Console.WriteLine("SE INGRESARON : "+positivos+ " NROS POSITIVOS ");
    }
}