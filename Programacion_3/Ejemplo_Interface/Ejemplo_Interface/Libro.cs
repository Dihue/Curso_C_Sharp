using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Interface
{
    internal class Libro : IColeccionable, IComparable
    {
        // Campos
        private string autor;
        private string titulo;

        // Propiedades
        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }

        // Constructor
        public Libro(string autor, string titulo)
        {
            this.autor = autor;
            this.titulo = titulo;
        }

        // Métodos
        public void Describir()
        {
            Console.WriteLine("Descripción...");
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
