/* El negocio de desinfectante antes mencionado vende además detergente suelto, y los precios
se aplican según la siguiente escala:
a. 25 ARS por litro los primeros 50 litros.
b. 20 ARS por litro si la venta es de 51 a 200 litros.
c. 15 ARS por litro si la venta es de 201 a 500 litros.
d. 10 ARS por litro si la venta es de más de 500 litros.
Además, si paga en efectivo, tiene un adicional del 10% sobre el importe final. Hacer un
programa que solicite la cantidad de litros vendidos y el tipo de pago (ingresará 1 si paga en
efectivo y 0 con cualquier otro medio de pago) y calcule y emita por pantalla el monto final
a abonar por el cliente */
int litros, tPago;
float monto;
Console.WriteLine("INGRESE LA CANTIDAD DE LITROS VENDIDOS : ");
litros = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE TIPO DE PAGO : ");
tPago = int.Parse(Console.ReadLine());

if(litros<=50)
   monto = 25*litros;
else if (litros>=51 && litros<=200)
   monto = 20*litros;
else if (litros>=201 && litros<=500)
   monto = 15*litros;
else
   monto = 10*litros;

if (tPago==1)
   monto =monto *0.90F;

Console.WriteLine("EL MONTO A PAGAR ES : $ "+monto.ToString("0.00"));


