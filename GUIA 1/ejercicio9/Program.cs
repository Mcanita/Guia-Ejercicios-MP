/* Una universidad desea conocer los porcentajes de	mujeres y hombres en las carreras de ciencias exactas.
Se solicita	un programa	para cargar la cantidad de mujeres y la cantidad de hombres y que el mismo calcule
y emita	por pantalla los porcentajes correspondientes */

int mujeres , hombres, alumnos  ;
float porMujeres, porHombres ;


Console.WriteLine("INGRESE EL TOTAL DE HOMBRES EN EXACTAS : ");
hombres = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL TOTAL DE MUJERES EN EXACTAS : ");
mujeres = int.Parse(Console.ReadLine());
alumnos = hombres + mujeres;
porMujeres = (mujeres *100)/ alumnos;
porHombres = 100 - porMujeres;
Console.WriteLine("EN EL CURSO HAY UN "+porMujeres.ToString("0.0") + " % DE MUJERES ");
Console.WriteLine("EN EL CURSO HAY UN "+porHombres.ToString("0.0")+ " % DE HOMBRES ");