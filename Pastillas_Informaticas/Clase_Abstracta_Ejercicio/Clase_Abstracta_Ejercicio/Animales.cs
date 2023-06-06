using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracta_Ejercicio
{
    internal abstract class Animales
    {
        // Método de clase
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        // Método abstracto de clase
        // Se debe implementar siempre en la clase hija
        public abstract void GetNombre();
    }
}
