using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Medico : Persona, IMedicos
    {
        int PExperiencia;

        public Medico(string nombre, int edad, string nacionalidad, int sueldo, int PExperiencia)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacionalidad = nacionalidad;
            this.Sueldo = sueldo;
            this.PExperiencia = PExperiencia;
        }

        public void Curar()
        {

        }

        public void Evaluar()
        {

        }
    }
}
