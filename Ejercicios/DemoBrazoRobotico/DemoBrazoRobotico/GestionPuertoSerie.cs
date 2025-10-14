using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBrazoRobotico
{
    internal class GestionPuertoSerie
    {
        private SerialPort puertoSerie;

        // ====== Obtener lista de puertos disponibles ======
        public List<string> ObtenerPuertosDisponibles()
        {
            List<string> listaPuertos = new List<string>();
            string[] puertos = SerialPort.GetPortNames();

            foreach (string p in puertos)
            {
                listaPuertos.Add(p);
            }

            return listaPuertos;
        }

        // ====== Conectarse a un puerto ======
        public bool Conectar(string nombrePuerto)
        {
            try
            {
                if (puertoSerie != null && puertoSerie.IsOpen)
                {
                    puertoSerie.Close();
                }

                puertoSerie = new SerialPort(nombrePuerto, 9600);
                puertoSerie.Encoding = Encoding.UTF8;
                puertoSerie.ReadTimeout = 2000; // Tiempo máximo de espera al leer (ms)
                puertoSerie.Open();

                return puertoSerie.IsOpen;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ====== Verificar si la conexión sigue activa ======
        public bool EstaConectado()
        {
            if (puertoSerie == null)
                return false;

            return puertoSerie.IsOpen;
        }

        // ====== Desconectarse ======
        public void Desconectar()
        {
            try
            {
                if (puertoSerie != null && puertoSerie.IsOpen)
                {
                    puertoSerie.Close();
                }
            }
            catch (Exception)
            {
                // No hacemos nada si ocurre un error al cerrar
            }
        }

        // ====== Enviar comando y recibir respuesta ======
        public string EnviarComando(string comando)
        {
            if (puertoSerie == null || !puertoSerie.IsOpen)
            {
                return "No hay conexión activa con el puerto serie.";
            }

            try
            {
                // Limpiar buffers antes de enviar
                puertoSerie.DiscardInBuffer();
                puertoSerie.DiscardOutBuffer();

                // Enviar comando al Arduino
                puertoSerie.WriteLine(comando);

                // Esperar un poco para que Arduino responda
                Thread.Sleep(200);

                // Leer respuesta del Arduino
                string respuesta = puertoSerie.ReadLine();
                return respuesta;
            }
            catch (TimeoutException)
            {
                return "No se recibió respuesta del Arduino (tiempo de espera agotado).";
            }
            catch (Exception ex)
            {
                return "Error al enviar comando: " + ex.Message;
            }
        }
    }
}
