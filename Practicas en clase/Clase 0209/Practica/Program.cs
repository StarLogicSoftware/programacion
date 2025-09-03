/*  EJERCICIO 1
Crea una clase Alumno con nombre y edad.
Agrega al menos 3 alumnos a una lista usando Add.
Muestra todos los alumnos con un foreach.
Muestra cuántos alumnos hay usando Count.
Buscar un alumno por nombre usando Find.
*/

using PracticaClase0209;

List<Alumno> listaAlumnos = new List<Alumno>();

// Agregar alumnos a la lista de manera dinámica
for (int i = 0; i < 2; i++)
{
    Alumno alumno = new Alumno();

    alumno.Cargar();

    listaAlumnos.Add(alumno);
}

Console.WriteLine();
// Mostrar la cantidad de alumnos
Console.WriteLine($"Cantidad de alumnos: {listaAlumnos.Count}");
// Mostrar todos los alumnos con foreach
foreach (var item in listaAlumnos)
{
    item.MostrarInformacion();
}

Console.Write("Busqueda de alumno. Ingresa el nombre a buscar: ");
string nombreBuscado = Console.ReadLine();

//Alumno busqueda = listaAlumnos.Find(x => x.NombreAlumno == nombreBuscado);
Alumno busqueda = listaAlumnos.Find(x => x.NombreAlumno.Contains(nombreBuscado));

if (busqueda == null)
{
    Console.WriteLine("No se encontro el alumno");
}
else
{
    Console.WriteLine($"Se encontro el alumno: {busqueda.NombreAlumno} " +
        $"y tiene {busqueda.Edad} años");
}
    

// forma manual y fija
/*
Alumno alumno1 = new Alumno();
alumno1.Nombre = "Juan";
alumno1.Edad = 20;

alumnos.Add(alumno1);

Alumno alumno2 = new Alumno();
alumno2.Nombre = "Pedro";
alumno2.Edad = 12;

alumnos.Add(alumno2);

Alumno alumno3 = new Alumno();
alumno3.Nombre = "Nicolas";
alumno3.Edad = 25;

alumnos.Add(alumno3);
*/