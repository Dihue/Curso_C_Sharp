using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
    internal class Mamifero
    {
        // Campos de clase
        private String nombreSerVivo;

        // Getters y Setters
        public string NombreSerVivo { get => nombreSerVivo; set => nombreSerVivo = value; }

        // Constructor
        public Mamifero(String nombre)
        {
            this.NombreSerVivo = nombre;
        }

        // Métodos de clase
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que puedan valerse por si mismas");
        }

        // Virtual: cuando el método será modificado por la clase que lo herede
        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }
    }
}
