/* Hacer un programa que permita ingresar por teclado dos números y que luego muestre por
pantalla la suma, la resta,	la multiplicación y	la división	de dichos números. Se deben
mostrar	cuatro resultados en pantalla. Los números deben ser solicitados una única vez.*/

int num1, num2 ;
int suma, resta , multiplicación, división;
Console.WriteLine("INGRESE EL PRIMER NRO : ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NRO : ");
num2 = int.Parse(Console.ReadLine());

suma = num1 + num2;
resta = num1 - num2;
multiplicación = num1 * num2;
división = num1 / num2;
Console.WriteLine("");
Console.WriteLine("LA SUMA DE LOS DOS NROS ES DE : "+ suma);
Console.WriteLine("LA RESTA  DE LOS DOS NROS ES DE : "+ resta);
Console.WriteLine("LA MULTIPLICACIÓN  DE LOS DOS NROS ES DE : "+multiplicación);
Console.WriteLine("LA DIVISIÓN DE LOS DOS NROS ES DE : "+división);
Console.WriteLine("");

