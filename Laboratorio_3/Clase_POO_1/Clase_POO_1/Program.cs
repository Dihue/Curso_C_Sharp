using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_POO_1
{
    // Clase abstracta
    abstract class serVivo
    {
        public string nombre { get; set; }
        public string peso { get; set;}
    }

    // Clase que hereda de la clase serVivo
    class Pato : serVivo
    {
        string color;

        public string Color // property
        {
            get { return color; } // get method
            set
            {
                if (value == "negro")
                {
                    Console.WriteLine("Los patos en mi mundo no son negros");
                    color = "rojo";
                }
                else
                {
                    color = value;
                }
            } // set method
        }

        // Constructor
        public Pato(string color, string peso, string nombre)
        {
            this.color = color;
            this.peso = peso;
            this.nombre = nombre;
        }

        // Funcion como el toString de Java
        public string mostrar()
        {
            return "El pato es " + this.color +
                    ", se llama " + this.nombre +
                    " y pesa " + this.peso + " kg";
        }
    }

    class Perro : serVivo
    {
        private string pelo;

        public string Pelo
        {
            get { return pelo; }

            set
            {
                if (value != "corto" || value != "largo")
                {
                    Console.WriteLine("Los perros pueden tener el pelo largo o corto");
                    pelo = "corto";
                }
                else
                {
                    pelo = value;
                }
            }
        }

        public Perro(string nombre, string peso)
        {
            this.nombre = nombre;
            this.peso = peso;
        }

        public string mostrar()
        {
            return "El perro se llama " + this.nombre +
                    ", tiene " + this.peso + " kg " +
                    " y su pelo es " + this.pelo;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pato pa = new Pato("negro", "2", "Lucas");
            Console.WriteLine("{0}", pa.mostrar());

            Perro pe = new Perro("Paco", "3");
            pe.Pelo = "listo";
            Console.WriteLine("{0}", pe.mostrar());

            Console.ReadKey();
        }
    }
}
