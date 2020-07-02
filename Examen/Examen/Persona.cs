using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class Persona
    {
        public string Nombre;
        public int Edad;
        public string Nacionalidad;
        public int Sueldo;

        public string MostrarInfo()
        {
            return ("Nombre: " + Nombre + " Edad: " + Edad + " Nacionalidad: " + Nacionalidad + " Sueldo: " + Sueldo);
        }
    }
}
