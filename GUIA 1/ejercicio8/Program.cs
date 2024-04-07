/* Una importante cadena de	delivery cuenta	con	una	promoción por tiempo limitado en la	que	otorga un 15%
de descuento sobre el total del valor de la	compra realizada. Hacer un programa	para solicitar el monto
 total y el mismo calcule y emita por pantalla el total	a cobrar con el descuento aplicado */
 
int total ;
float totalCobrar;
Console.WriteLine("INGRESE EL TOTAL DE LA COMPRA : ");
total = int.Parse(Console.ReadLine());
totalCobrar = total * 0.85F;
Console.WriteLine("EL TOTAL A PAGAR CON EL DESCEUNTO DEL 15 % ES DE : "+ totalCobrar.ToString("0.00"));
