using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    internal class Gorilla : Mamifero
    {
        // Constructor
        public Gorilla(string nombre) : base(nombre)
        {
        }

        // Métodos de la clase
        public void Trepar()
        {
            Console.WriteLine("Es capaz de tretar árboles");
        }

        // OVERRIDE: sobreescritura o modificación del método de la superclass
        public override void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
    }
}
