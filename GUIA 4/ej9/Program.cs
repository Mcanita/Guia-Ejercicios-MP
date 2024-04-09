/* Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas
personas mayores a 18 años */

int edad,mayor=0,cont=0;
float prom;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("INGRESE UNA EDAD: ");
    edad= int.Parse(Console.ReadLine());
    if(edad>=18)
    {
        mayor+=edad;
        cont++;
    }
}
prom= mayor/cont;
Console.WriteLine("el promedio de los mayores de edad es : "+prom);
