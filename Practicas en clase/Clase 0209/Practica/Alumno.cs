using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase0209
{
    public class Alumno
    {
        public string NombreAlumno;
        public int Edad;

        public void Cargar()
        {
            Console.Write("Ingrese el nombre del alumno: ");
            NombreAlumno = Console.ReadLine();
            Console.Write("Ingrese la edad del alumno: ");
            Edad = int.Parse(Console.ReadLine());
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {NombreAlumno}, Edad: {Edad}");
        }
    }
}
