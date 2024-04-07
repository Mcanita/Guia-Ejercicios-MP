/* Hacer un programa que solicite el ingreso de dos números y luego calcular:
a. La resta si el primero es mayor que el segundo.
b. La suma si son iguales.
c. El producto si el primero es menor.
Se deberá emitir un cartel por pantalla con el resultado correspondiente */

int n1, n2, resultado;
Console.WriteLine("INGRESE EL PRIMER NRO : ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NRO : ");
n2 = int.Parse(Console.ReadLine());

if(n1>n2)
{
    resultado = n1 - n2;
    Console.WriteLine("SE HA REALIZADO UNA RESTA, EL RESULTADO ES : "+resultado);
}
else if(n1 == n2)
{
    resultado = n1 + n2;
    Console.WriteLine("SE HA REALIZADO UNA SUMA, EL RESULTADO ES : "+resultado);
}
else
{
    resultado = n1 * n2;
    Console.WriteLine("SE HA REALIZADO UNA MULTIPLICACIÓN , EL RESULTADO ES : "+resultado);

}
  
