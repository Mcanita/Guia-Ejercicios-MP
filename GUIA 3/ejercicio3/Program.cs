/*  Hacer un programa para ingresar dos números. Si el segundo es distinto de cero, calcular
la división del primero por el segundo y mostrar el resultado por pantalla; caso contrario,
emitir un cartel aclarando que no se puede dividir por cero  */

int num1, num2, resultado;
Console.WriteLine("INGRESE EL PRIMER NRO : ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NRO : ");
num2 = int.Parse(Console.ReadLine());

if(num2 !=0)
{
    resultado = num1 / num2;
    Console.WriteLine("EL RESULTADO DE LA DIVISIÓN ES : "+resultado);
}
else
{
    Console.WriteLine("NO SE PUEDE DIVIDIR POR 0 ");
}
