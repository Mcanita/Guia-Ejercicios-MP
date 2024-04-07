/* Hacer	un	programa	que	permita	ingresar	los	kilómetros	existentes	entre	dos	
ciudades	y	la	velocidad	promedio	de	un	vehículo.	Calcular	y	emitir	por	pantalla	
el	tiempo	aproximado	que	demandará	llegar	de	un	punto	a	otro	teniendo	en	
cuenta	los	datos	ingresados. */

float kilometros , velocidad ;
float tiempo ;

Console.WriteLine("INGRESE LOS KM DE DISTANCIA QUE DEBE RECORRER : ");
kilometros = float.Parse(Console.ReadLine());
Console.WriteLine("INGRESE LA VELOCIDAD PROMEDIO EN LA QUE VIAJA : ");
velocidad = float.Parse(Console.ReadLine());
tiempo = kilometros / velocidad;
Console.WriteLine("EL TIEMPO APROXIMADO DE LLEGADA ES DE : "+ tiempo.ToString("0.00"));

