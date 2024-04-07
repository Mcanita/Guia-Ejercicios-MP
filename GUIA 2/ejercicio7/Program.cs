/*Hacer un programa	para ingresar cuatro números distintos y luego mostrar por pantalla	
el mayor de	ellos*/

int num1, num2, num3, num4;
Console.WriteLine("INGRESE EL PRIMER NÚMERO : ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NÚMERO : ");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL TERCERO NÚMERO : ");
num3 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL CUARTO NÚMERO : ");
num4 = int.Parse(Console.ReadLine());

if(num1>num2 && num1>num3 &&num1>num4)
  Console.WriteLine("EL NRO "+num1+" ES EL MAYOR ");
else if (num2>num1 && num2>num3 && num2>num4 )
  Console.WriteLine("EL NRO "+num2+" ES EL MAYOR ");
else if (num3>num1 && num3>num2 && num3>num4)
  Console.WriteLine("EL NRO "+num3+" ES EL MAYOR ");
else 
  Console.WriteLine("EL NRO "+num4+" ES EL MAYOR ");
