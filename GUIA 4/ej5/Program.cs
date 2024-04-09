/* Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo:
0, 5, 10, 15, 20…. 100. */
internal partial class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i <=100; i=i+5)
        {
            Console.WriteLine(i);
        }
    }
}