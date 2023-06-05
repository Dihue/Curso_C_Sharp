using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
    internal class Gorilla : Mamifero, IMamiferosTerrestres
    {
        // Constructor
        public Gorilla(String nombreGorilla) : base(nombreGorilla)
        {

        }

        // Método de clase
        public void Tretar()
        {
            Console.WriteLine("Soy capaz de tretar árboles");
        }

        // Override: sobreescritura del método de la superclass
        public override void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }

        // Método que viene desde la interface
        public int NumeroDePatas()
        {
            return 2;
        }
    }
}
