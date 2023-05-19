using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Interface
{
    internal interface IColeccionable
    {
        // Propiedades
        string Titulo { get; set; }

        // Métodos
        void Describir();
    }
}
