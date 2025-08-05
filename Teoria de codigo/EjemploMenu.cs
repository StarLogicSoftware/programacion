while (true)
{
    Console.WriteLine("Programa de ejemplo de menu 2.0");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("Opcion 0 cualquiera");
    Console.WriteLine("1- sumar dos numeros");
    Console.WriteLine("2- restar dos numeros");
    Console.WriteLine("3- salir");
    Console.WriteLine();
    Console.Write("Opcion elegida: ");
    int opcion = int.Parse(Console.ReadLine());


    switch (opcion)
    {
        case 1:
            Console.WriteLine("Resultado de la suma: " + (2 + 3));
            break;
        case 2:
            Console.WriteLine("Resultado de la resta: " + (2 - 3));
            break;
        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción incorrecta, por favor intente de nuevo.");
            break;
    }
}
