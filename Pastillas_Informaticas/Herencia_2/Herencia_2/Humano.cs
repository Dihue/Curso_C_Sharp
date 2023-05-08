using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    internal class Humano : Mamifero
    {
        // Constructor con la base de la superclass
        public Humano(string nombre) : base(nombre)
        {
        }

        // Método de clase
        // OVERRIDE se usa cuando se sobreescribe o modifica el método de la superclass
        public override void Pensar()
        {
            Console.WriteLine("Es capas de pensar");
        }
    }
}
