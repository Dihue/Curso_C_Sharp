using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
    internal class Humano : Mamifero
    {
        // Constructor
        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }

        // Método de clase
        // Override: sobreescritura del método de la superclass
        public override void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }
}
