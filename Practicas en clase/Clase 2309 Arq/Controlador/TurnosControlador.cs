using Clase_2309_Arq.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2309_Arq.Controlador
{
    public class TurnosControlador
    {
        public List<Turno> turnosActivos = new List<Turno>();

        public bool ReservarTurno(string nombre, DateTime fecha)
        {
            if(string.IsNullOrEmpty(nombre) || fecha < DateTime.Now)
            {
                return false;
            }
            else
            {
                Turno turnoReservar = new Turno();
                turnoReservar.NombreCliente = nombre;
                turnoReservar.FechaTurno = fecha;

                turnosActivos.Add(turnoReservar);

                return true;
            }    
        }

        public List<Turno> ListarTurnos()
        {
            return turnosActivos;
        }

        public Turno BuscarPorNombre(string nombreAReservar)
        {
            Turno turnoReservado = turnosActivos.Find(x => x.NombreCliente == nombreAReservar);

            return turnoReservado;
        }

        public void MarcarTurnoComoCompletado(Turno turnoDesdeDtg)
        {
            turnosActivos.Remove(turnoDesdeDtg);

            turnoDesdeDtg.Asistio = true;

            turnosActivos.Add(turnoDesdeDtg);
        }
    }
}
