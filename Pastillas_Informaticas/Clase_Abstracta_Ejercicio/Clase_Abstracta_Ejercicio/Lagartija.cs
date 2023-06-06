using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracta_Ejercicio
{
    internal class Lagartija : Animales
    {
        // Campos de clase
        private String nombre;

        // Getters y Setters
        public String Nombre { get { return nombre; } set { nombre = value; } }

        // Constructor
        public Lagartija(String nombre)
        {
            this.nombre = nombre;
        }

        // Método sobreescrito que viene de la herencia con la clase Animales
        public override void GetNombre()
        {
            Console.WriteLine("El nombre del reptil es " + nombre);
        }
    }
}
