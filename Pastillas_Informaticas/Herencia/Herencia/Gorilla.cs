using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Gorilla : Mamifero
    {
        public Gorilla(string nombre) : base(nombre)
        {
        }

        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
