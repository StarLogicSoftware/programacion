
//// Declarar una variable
//int miVariable;

//// Guardar un dato FIJO en la variable
//miVariable = 20;

//miVariable = int.Parse(Console.ReadLine());

//Console.Write("El valor que hay dentro de la variable es: ");
//Console.WriteLine(miVariable);

// Pedir dos numeros por consola y mostrar su promedio
//float nota1,nota2,resultado;

//Console.WriteLine("Ingrese la primer nota: ");
//nota1 = float.Parse(Console.ReadLine());

//Console.WriteLine("Ingrese la segunda nota");
//nota2 = float.Parse(Console.ReadLine());

//resultado = (nota1 + nota2) / 2;

//Console.Write("El promedio es: ");
//Console.WriteLine(resultado);

//int miVariable;

//miVariable = 20;

//if (miVariable > 7) // si 9 es mayor que 7
//{
//    Console.Write("Es mayor que 7 ");
//}
//else // sinó
//{ // las llaves son para delimitar un bloque de código
//    Console.Write("Es menor que 7 ");
//}



// EJERCICIO DE CONDICIONALES
// Pedir la edad de una persona y notificar si
// se puede incribir al curso de programación

int edad;

Console.WriteLine("Ingrese la edad del postulante: ");
edad = int.Parse(Console.ReadLine());

if (edad >= 15)
{
    Console.WriteLine("Se puede inscribir al INCREIBLE curso de programación");
}
else
{
    Console.WriteLine("No tiene edad suficiente para inscribirse");
}

// Bucles
// Definido

for (int contador = 0; contador < 10; contador++)
{
    // lineas a repetir una X cantidad de veces
}

// indefinidos
// while (pregunta y hace) / do-while (hace y pregunta)

while (2 > 7)
{
    // lineas a repetir
}

do
{
    // lineas a repetir
} while (2 > 7);
// Prestar atención a que luego del while() hay un ";"

Console.WriteLine("aca termina todo");

