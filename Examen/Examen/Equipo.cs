using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Equipo
    {
        string Nombre;
        string Nacionalidad;
        bool Liga;
        public List<Jugador> Jugadores = new List<Jugador>();
        Entrenador Entrenador;
        Medico Medico;

        public Equipo(string nombre, string nacionalidad, bool liga, Entrenador entrenador, Medico medico)
        {
            this.Nombre = nombre;
            this.Nacionalidad = nacionalidad;
            this.Liga = liga;
            this.Entrenador = entrenador;
            this.Medico = medico;
        }

        public void AgregarJugador(Jugador jugador)
        {
            if (Liga == false && jugador.Nacionalidad != Nacionalidad)
            {
                Console.WriteLine("El jugador " + jugador.Nombre + " no puede ingresar a este equipo ya que no tiene la misma nacionalidad");
            }

            else
            {
                Jugadores.Add(jugador);
                Console.WriteLine("El jugador " + jugador.Nombre + " ha sido agregado exitosamente al equipo: " + Nombre);
            }
        }

        public void MostrarInfo()
        {
            string tipo;
            if (Liga == false)
            {
                tipo = "Nacional";
            }
            else
            {
                tipo = "Liga";
            }
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Nacionalidad: " + Nacionalidad);
            Console.WriteLine("Tipo: " + tipo);

            Console.WriteLine("Entrenador: " + Entrenador.Nombre);

            Console.WriteLine("Medico: " + Medico.Nombre);

            Console.WriteLine("Jugadores: ");
            foreach (Jugador jugador in Jugadores)
            {
                Console.WriteLine("\t" + jugador.Nombre);
            }

        }
    }
}
