float totalMedidaVarillas = 0, 
    precioBarra,
    precioTotalBarras, 
    precioTotalVarillas;

int cantidadBarras;

totalMedidaVarillas = ObtenerTotalMedidaVarillas();

cantidadBarras = CalcularTotalBarras(totalMedidaVarillas);

precioBarra = SolicitarNumeroFloat("Ingrese el precio de la barra: ");

precioTotalBarras = cantidadBarras * precioBarra;

precioTotalVarillas = (precioBarra / 6) * totalMedidaVarillas;

//---------------
MostrarResultados(totalMedidaVarillas, cantidadBarras, precioTotalVarillas, precioTotalBarras);


float ObtenerTotalMedidaVarillas()
{
    float totalVarillasFuncion = 0;
    float tramoVarillaFuncion = 0;

    tramoVarillaFuncion = SolicitarNumeroFloat("Ingrese el tramo de varilla: ");

    while (tramoVarillaFuncion != 0)
    {
        totalVarillasFuncion += tramoVarillaFuncion;

        tramoVarillaFuncion = SolicitarNumeroFloat("Ingrese el tramo de varilla: ");
    }

    return totalVarillasFuncion;
}

float SolicitarNumeroFloat(string mensaje)
{
    Console.Write(mensaje);
    return float.Parse(Console.ReadLine());
}

void MostrarResultados(float totalVarillas, int cantidadDeBarras, float CostoVarillas, float costoBarras)
{
    Console.WriteLine(); // writeline para hacer un espacio y no se mezcle todo
    Console.Write("El total de varillas fue de: ");
    Console.WriteLine(totalVarillas);
    Console.Write("El total de barras completas es de: ");
    Console.WriteLine(cantidadDeBarras);
    Console.Write("El precio total en varillas es de: ");
    Console.WriteLine(CostoVarillas);
    Console.Write("El precio total en barras es de: ");
    Console.WriteLine(costoBarras);
}

int CalcularTotalBarras(float totalVarillas)
{
    int cantidadBarras = (int)totalVarillas / 6;
    return cantidadBarras;
    // forma resumida
    // return (int)totalVarillas / 6;
}
