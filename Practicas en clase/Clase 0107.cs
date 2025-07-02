// Ejercicio 2 - Practica de funciones
// Link al documento > https://github.com/StarLogicSoftware/programacion/blob/main/Ejercicios/Practica%20de%20funciones.md

float lado1, lado2;

float resultado = CalcularPerimetro(5, 10);

lado1 = SolicitarLado("A");
lado2 = SolicitarLado("B");


// Falta calcular el area y el perimetro y mostrar los resultados

float SolicitarLado(string lado)
{
    float numero;

    numero = solicitarFloat($"Ingrese el lado {lado}");

    while (numero <= 0)
    {
        Console.WriteLine("El numero es incorrecto");

        numero = solicitarFloat($"Ingrese el lado {lado}");
    }

    return numero;
}

// funcion dedicada exclusivamente a obtener un float
float solicitarFloat(string mensaje)
{
    bool falla = false;
    float numero = 0;

    do
    {
        try
        {
            Console.WriteLine(mensaje);
            numero = float.Parse(Console.ReadLine());
            falla = false;
        }
        catch (Exception)
        {
            falla = true;
        }

    } while (falla == true);

    return numero;
}


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