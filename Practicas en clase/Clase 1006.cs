/* 
Desarrollar un programa que permita la carga de 10 valores por
teclado y nos muestre posteriormente la suma de los valores
ingresados y su promedio.
ya no sean 10 valores, sino que la persona carga los que quiere */

// v3- Indicar la cantidad de numeros que son mayores que 6
// indicar el porcentaje del total que fueron mayores que 6
/*
float numero;
float suma = 0;
float promedio;
float cantidadNumeros = 0;
float cantidadMayores = 0;
float porcentajeMayores;

do
{
    Console.WriteLine("Ingrese un numero: ");
    numero = float.Parse(Console.ReadLine());
    if (numero != 0)
    {
        suma += numero;
        cantidadNumeros++;

        // Si es mayor que 6, lo voy sumando en la variable cantidadMayores
        if(numero > 6)
        {
            cantidadMayores++;
        }
    }
} while (numero != 0);

porcentajeMayores = (cantidadMayores / cantidadNumeros) * 100;
promedio = suma / cantidadNumeros;

Console.Write("La suma de los valores son: ");
Console.WriteLine(suma);
Console.Write("el promedio de los valores es: ");
Console.WriteLine(promedio);
Console.Write("La cantidad de mayores que 6 fueron: ");
Console.WriteLine(cantidadMayores);
Console.Write("el procentaje de mayores que 6 fueron: ");
Console.Write(porcentajeMayores);
Console.WriteLine("%");


// con bucle while

float numero;
float suma = 0;
float promedio;
int cantidadNumeros = 0;

Console.WriteLine("Ingrese un numero: ");
numero = float.Parse(Console.ReadLine());

while (numero != 0) // mientras
{
    suma += numero; // suma = suma + numero;
    cantidadNumeros++;
    Console.WriteLine("Ingrese un numero: ");
    numero = float.Parse(Console.ReadLine());
}

promedio = suma / cantidadNumeros;

Console.Write("La suma de los valores son: ");
Console.WriteLine(suma);
Console.Write("el promedio de los valores es: ");
Console.WriteLine(promedio);
*/


/*
float numero;
float suma = 0;
float promedio;
int cantidadNumeros;

Console.WriteLine("Cuantos datos queres cargar?");
cantidadNumeros = int.Parse(Console.ReadLine());

for (int i = 0; i < cantidadNumeros; i++)
{
    numero = float.Parse(Console.ReadLine());
    suma = suma + numero;
}

promedio = suma / cantidadNumeros;

Console.Write("La suma de los valores son: ");
Console.WriteLine(suma);
Console.Write("el promedio de los valores es: ");
Console.WriteLine(promedio);
*/


int edad = 21;
string nombre = "Nicolas";

Console.Write("Mi nombre es ");
Console.Write(nombre);
Console.Write(" y mi edad es ");
Console.Write(edad);
Console.WriteLine(" años");

// concatenacion
Console.WriteLine("Mi nombre es " + nombre + " y mi edad es " + edad + " años");

// interpolacion de strings
Console.WriteLine($"Mi nombre es {nombre} y mi edad es {edad} años");