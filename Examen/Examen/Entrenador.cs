using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Entrenador : Persona, IEntrenadores
    {
        int PTactica;

        public Entrenador(string nombre, int edad, string nacionalidad, int sueldo, int PTactica)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacionalidad = nacionalidad;
            this.Sueldo = sueldo;
            this.PTactica = PTactica;
        }

        public void CambiarJugador()
        {

        }
    }
}
