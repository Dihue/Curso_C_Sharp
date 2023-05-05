using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    public class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void Saludar()
        {
            Console.WriteLine("Hola, soy una persona");
        }
    }

    public class Estudiante : Persona
    {
        public Estudiante(string nombre) : base(nombre)
        {

        }

        public override void Saludar()
        {
            Console.WriteLine("Hola, soy un estudiante");
        }
    }

    internal class Pregunta_4
    {
    }
}
