using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * WHILE == "mientras"
 * Se utiliza el bucle cuando no sabes la cantidad de veces que se repetirá
 * el código en su interior
 */

namespace Bucle_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Entrar en el bucle? si/no");
            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("Estás dentro del bucle");
                Console.WriteLine("Introduce tu nombre:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Para salir del bucle, escribir no");
                Console.WriteLine("¿Deseas repetir?");

                // Sobreescribimos para poder salir del bucle
                respuesta = Console.ReadLine();
            }
            Console.WriteLine("Saliste del bucle");
        }
    }
}
