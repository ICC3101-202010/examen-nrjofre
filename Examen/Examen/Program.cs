using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Entrenador entrenador1 = new Entrenador("Mauricio Castro", 43, "Chileno", 20000000, 97);
            Entrenador entrenador2 = new Entrenador("Alberto Fariña", 39, "Chileno", 20000000, 97);

            Medico medico1 = new Medico("Alonso Ibarra", 32, "Brasileño", 10000000, 95);
            Medico medico2 = new Medico("Paulino Torre", 30, "Argentino", 10000000, 95);

            Jugador jugador1 = new Jugador("Lucas Bolaños", 22, "Chileno", 1000000, 97, 97, false);
            Jugador jugador2 = new Jugador("Guillermo Garca", 23, "Chileno", 1000000, 97, 97, false);
            Jugador jugador3 = new Jugador("Luis Picazo", 22, "Argentino", 1000000, 97, 97, false);
            Jugador jugador4 = new Jugador("Leandro Rovira", 25, "Español", 1000000, 97, 97, false);
            Jugador jugador5 = new Jugador("Rogelio Julian", 21, "Peruano", 1000000, 97, 97, false);
            

            Equipo equipoNacional = new Equipo("Chile", "Chileno", false, entrenador1, medico1);

            Equipo equipoLiga = new Equipo("Boca Juniors", "Argentino", true, entrenador2, medico2);

            equipoNacional.AgregarJugador(jugador1);
            equipoNacional.AgregarJugador(jugador2);
            equipoNacional.AgregarJugador(jugador3);
            equipoNacional.AgregarJugador(jugador4);
            equipoNacional.AgregarJugador(jugador5);
           
            equipoNacional.MostrarInfo();
            Console.WriteLine();

            equipoLiga.AgregarJugador(jugador1);
            equipoLiga.AgregarJugador(jugador2);
            equipoLiga.AgregarJugador(jugador3);
            equipoLiga.AgregarJugador(jugador4);
            equipoLiga.AgregarJugador(jugador5);

            equipoLiga.MostrarInfo();




            Console.ReadKey();
        }
    }
}
