using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    internal class Caballo : Mamifero
    {
        // Constructor
        public Caballo(string nombre) : base(nombre)
        {
        }

        // Método de la clase
        public void Galopar()
        {
            Console.WriteLine("Es capaz de galopar");
        }
    }
}
