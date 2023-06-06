using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Abstracta_Ejercicio
{
    internal class Mamiferos : Animales
    {
        // Campos de clase
        private String nombre;

        // Getters y Setters
        public String Nombre { get { return nombre; } set {  nombre = value; } }

        // Constructor
        public Mamiferos(String nombre)
        {
            this.nombre = nombre;
        }

        // Métodos de la clase Mamíferos
        public void CuidarCrias()
        {
            Console.WriteLine("Cuida a sus crías hasta que puedan valerse por si mismas");
        }

        public void Pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        // Método sobreescrito que viene de la herencia con la clase Animales
        public override void GetNombre()
        {
            Console.WriteLine("El nombre del mamífero es " + nombre);
        }
    }
}
