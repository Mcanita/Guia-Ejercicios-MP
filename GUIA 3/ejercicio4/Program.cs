/*  Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la
cantidad de litros vendidos según la siguiente escala:

a. Si vende menos de 100 litros, no hay descuento.
b. Si vende entre 101 y 300 litros, el descuento es del 10%.
c. Si vende entre 301 y 500 litros, el descuento es del 15%.
d. Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros
vendidos y calcule y emita el importe con el descuento aplicado  */

int litros, precio;
float total;
Console.WriteLine("INGRESE LA CANTIDAD DE LITROS VENDIDOS : ");
litros = int.Parse(Console.ReadLine());
Console.WriteLine("PRECIO TOTAL DE LA VENTA  : ");
precio = int.Parse(Console.ReadLine());

if(litros<=100)
{
    Console.WriteLine("NO POSEE DESCUENTO , EL TOTAL A ABONAR ES : "+precio);
}
else if(litros >= 101 && litros<= 300)
{
    total = precio * 0.9F;
    Console.WriteLine("TIENE UN 10 % DE  DESCUENTO , EL TOTAL A ABONAR ES : "+total);
}
else if(litros >= 301 && litros<= 500)
{
    total = precio * 0.85F;
    Console.WriteLine("TIENE UN 15 % DE  DESCUENTO , EL TOTAL A ABONAR ES : "+total);
}
else
{
    total = precio * 0.75F;
    Console.WriteLine("TIENE UN 25% DE  DESCUENTO , EL TOTAL A ABONAR ES : "+total);
}
  


