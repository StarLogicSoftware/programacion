using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0909.Clases
{
    public class Usuario
    {
        private string Nombre;
        private int Edad;

        public void CargarDatos(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string MostrarDatos()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}";
        }
    }
}
