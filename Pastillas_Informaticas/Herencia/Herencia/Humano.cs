using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    // Se aplica herencia desde Mamífero
    internal class Humano : Mamifero
    {
        public Humano(string nombre) : base(nombre)
        {
        }

        public void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }
}
