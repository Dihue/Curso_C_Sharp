using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracta_Ejercicio
{
    internal class Caballo : Mamiferos, IMamiferoTerrestre
    {
        // Constructor
        public Caballo(string nombre) : base(nombre)
        {
        }

        // Método de clase
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        // Método de la interface
        public int NumeroDePatas()
        {
            return 4;
        }
    }
}
