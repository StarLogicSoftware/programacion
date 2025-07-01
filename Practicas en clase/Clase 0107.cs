// Ejercicio 2


float lado1, lado2;

float resultado = CalcularPerimetro(5, 10);


float CalcularArea(float ladoA, float ladoB)
{
    return (ladoA * ladoB);
}

float CalcularPerimetro(int ladoA, int ladoB)
{
    return (ladoA * 2) + (ladoB * 2);
}

void MostrarResultados(float area, float perimetro, float ladoA, float ladoB)
{
    Console.WriteLine($"El rectangulo de lado a={ladoA} y lado b={ladoB} tiene un área de {area}cm2 y " +
        $"un perímetro de {perimetro}cm");
}


















/* EJERCICIO 1
float cotizacion = 1240; // Cotización del dólar
float cantidadPesos, cantidadDolares;

cantidadPesos = PedirCantidadPesos();
cantidadDolares = convertADolares(cantidadPesos, cotizacion);

MostrarResultados(cantidadPesos, cantidadDolares);
void MostrarResultados(float pesos, float dolares)
{
    Console.WriteLine($"La cantidad de pesos {pesos} equivale a {dolares} dolares.");
}
float convertADolares(float cantidad, float cotizacion)
{
    float resultado = cantidad / cotizacion;
    return resultado;
}
float PedirCantidadPesos()
{
    Console.Write("Ingrese la cantidad de pesos a convertir: ");
    float cantidad = float.Parse(Console.ReadLine());
    return cantidad;
}
*/