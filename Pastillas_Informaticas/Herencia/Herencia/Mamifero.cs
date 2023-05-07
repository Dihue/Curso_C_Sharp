using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Mamifero
    {
        public Mamifero(string nombre)
        {
            nombreSerVivo = nombre;
        }

        public void Respirar()
        {
            Console.WriteLine("Es capaz de respirar");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuida de las crías hasta que se protegan solas");
        }

        public string NombreSerVivo { get => nombreSerVivo; set => nombreSerVivo = value; }

        private string nombreSerVivo;
    }
}
