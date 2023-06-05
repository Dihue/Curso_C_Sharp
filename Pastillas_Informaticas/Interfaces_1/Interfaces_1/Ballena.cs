using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
    internal class Ballena : Mamifero
    {
        // Constructor
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }

        // Métodos de clase
        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}
