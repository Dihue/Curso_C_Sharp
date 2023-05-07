using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    // Se aplica herencia usando : y el llamado a la superclass
    // Tiene acceso a los métodos de la superclass
    internal class Caballo : Mamifero
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {
        }

        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
}
