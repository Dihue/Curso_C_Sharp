using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    internal class Mamifero
    {
        // Campos
        private string nombre;

        // Getters y Setters
        public string Nombre { get => nombre; set => nombre = value; }

        // Constructor
        public Mamifero(string nombre)
        {
            this.nombre = nombre;
        }

        // Métodos de la clase
        public void Amamantar()
        {
            Console.WriteLine("Amamanta a su cría hasta que se vale por si misma");
        }

        public void Respirar()
        {
            Console.WriteLine("Es capaz de respirar");
        }

        // VIRTUAL se usa cuando el método será reutilizado y modificado por la clase hija
        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }
    }
}
