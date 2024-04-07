/* Una casa	de video juegos otorga un descuento	dependiendo	del	importe de la compra realizada
según los siguientes valores:
• Si el	importe	es	menor a	ARS	1000, no hay descuento.
• Si el	importe	es ARS 1000 o más pero menor a ARS 5000, aplica	un descuento del 10%.
• Si el	importe	es ARS 5000	o más, aplica un descuento del 18%.
Hacer un programa para ingresar	un importe de venta	y luego	muestre	por	pantalla el	importe
final con el descuento que corresponda */

int total;
float totalConDescuento;
Console.WriteLine("INGRESE EL TOTAL DE L COMPRA : ");
total = int.Parse(Console.ReadLine());

if(total<1000)
   Console.WriteLine("NO POSEE DESCUENTO , EL TOTAL A ABONAR ES : "+ total);
else if (total>=1000 && total<5000)
{
    totalConDescuento = total * 0.9F;
    Console.WriteLine("EL DESCUENTO ES DEL 10% , EL TOTAL A ABONAR ES : "+totalConDescuento.ToString("0.00"));
}
else 
{
    totalConDescuento = total * 0.82F;
    Console.WriteLine("EL DESCUENTO ES DEL 18%, EL TOTAL A ABONAR ES : "+totalConDescuento.ToString("0.00"));

}

