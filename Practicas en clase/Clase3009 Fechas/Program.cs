

DateTime FechaVenta;
DateTime FechaGarantia;

FechaVenta = DateTime.Now;
FechaGarantia = FechaVenta.AddDays(5);

if(DateTime.Now > FechaGarantia)
{
    Console.WriteLine("La garantia ha expirado");
}
else
{
    Console.WriteLine("La garantia sigue vigente");
}

Console.WriteLine(FechaVenta);