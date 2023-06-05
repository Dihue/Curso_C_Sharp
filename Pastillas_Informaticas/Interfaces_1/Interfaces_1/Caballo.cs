using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
    internal class Caballo : Mamifero, IMamiferosTerrestres
    {
        // Constructor
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }

        // Método de clase
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        // Método que proviene de la interface
        public int NumeroDePatas()
        {
            return 4;
        }
    }
}
