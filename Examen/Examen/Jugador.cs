using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Jugador : Persona
    {
        public int PAtaque;
        public int PDefensa;
        public int NumeroC;
        public bool Arquero;
        public bool Lesionado;

        public Jugador(string nombre, int edad, string nacionalidad, int sueldo, int PAtaque, int PDefensa, bool arquero)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Nacionalidad = nacionalidad;
            this.Sueldo = sueldo;
            this.PAtaque = PAtaque;
            this.PDefensa = PDefensa;
            this.Arquero = arquero;
        }

        public void JugarEnCancha()
        {

        }

        public void JugarAlArco()
        {
            //si el atributo arquero es false aqui el metodo retornaria nada o un error
        }
    }
}
