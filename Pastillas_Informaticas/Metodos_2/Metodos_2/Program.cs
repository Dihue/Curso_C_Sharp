using System;

/*
 * Métodos en C#:
 * Declaración y llamada a métodos void
 * Paso de parámetros
 */

namespace Metodos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Llamado al método
            mensajeEnPantalla();

            sumaNumeros(5,3);
        }

        // Método
        static void mensajeEnPantalla()
        {
            Console.WriteLine("\nMensaje desde el método msjPantalla\n");
        }

        // Método con parámetros
        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma de los números es {num1 + num2}");
        }
    }
}
