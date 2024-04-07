// Hacer	un	programa	que	permita	ingresar	el	año	actual	y	el	año	de	la	fecha	de	
// nacimiento	de	una	persona	y	luego	calcule	y	emita	por	pantalla	su	edad


int anoActual , anoNacimiento, edad ;
Console.WriteLine("INGRESE EL AÑO ACTUAL : ");
anoActual = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE AÑO DE NACIMIENTO : ");
anoNacimiento = int.Parse(Console.ReadLine());
edad = anoActual - anoNacimiento;
Console.WriteLine("USTED TIENE : "+edad+ " AÑOS DE EDAD ");
