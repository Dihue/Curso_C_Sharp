/*
 * Llamadas y clases Math
 * Variables y métodos static
 * Importar métodos static
 * Clase anónimas
 */
// Importar todos los métodos estáticos de la clase Math
//using static System.Math;
//using static System.Console;

namespace Conceptos_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

            // Clase Anónima
            var miVariable = new { Nombre = "Juan", Edad = 19 };

            /*
             * Requisitos Clases Anónimas
             * Solo pueden contener campos públicos
             * Todos los campos deben estar iniciados
             * Los campos no pueden ser static
             * No se pueden definir métodos
             */

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();

            Punto destino = new Punto(128, 80);

            Punto otroPunto = new Punto();

            double distancia = Math.Round((origen.DistanciaHasta(destino)),3);

            Console.WriteLine($"La distancia entre los puntos es {distancia}");

            Console.WriteLine($"Números de objeto creado: {Punto.getContadorObjeto()}");
        }
    }
}