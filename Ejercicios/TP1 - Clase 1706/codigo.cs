// Tp01 - clase 1
// https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/arithmetic-operators#round-off-errors

/* minitarea:
 * Buscar sobre clase Math -> calculos matematicos complejos)
 * Buscar sobre conversion de tipos explicitos (int)
 * Buscar sobre conversion con clase Convert
 */

float tramoVarilla, totalMedidaVarillas = 0, precioBarra, 
    precioTotalBarras, precioTotalVarillas;
int cantidadBarras;

//------------ con bucle while --------------------------------------

Console.Write("Ingrese el tramo de varilla: ");
tramoVarilla = float.Parse(Console.ReadLine());

while (tramoVarilla != 0)
{
    totalMedidaVarillas += tramoVarilla;

    Console.Write("Ingrese el tramo de varilla: ");
    tramoVarilla = float.Parse(Console.ReadLine());
}

cantidadBarras = (int)(totalMedidaVarillas / 6); // conversion explicita de tipos

Console.Write("Ingrese el precio de la barra: ");
precioBarra = float.Parse(Console.ReadLine());

precioTotalBarras = cantidadBarras * precioBarra;

// barra de 6 metros -> 6000
// total de varillas -> X 
precioTotalVarillas = (precioBarra / 6) * totalMedidaVarillas;

Console.WriteLine(); // writeline para hacer un espacio y no se mezcle todo
Console.Write("El total de varillas fue de: ");
Console.WriteLine(totalMedidaVarillas);
Console.Write("El total de barras completas es de: ");
Console.WriteLine(cantidadBarras);
Console.Write("El precio total en varillas es de: ");
Console.WriteLine(precioTotalVarillas);
Console.Write("El precio total en barras es de: ");
Console.WriteLine(precioTotalBarras);

/*----------- esto con do-while -------------------------
do
{
    Console.Write("Ingrese el tramo de varilla: ");
    tramoVarilla = float.Parse(Console.ReadLine());

    totalMedidaVarillas += tramoVarilla;

} while (tramoVarilla != 0); 
*/
