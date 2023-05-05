using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Particularidades de la sintaxis del condicional if
 * Uso de operadores lógico
 * Uso de "else if"
 */

namespace Condicional_if_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nVamos a evaluar si puedes conducir");
            Console.WriteLine("Introduce tu edad:");

            int edad = int.Parse(Console.ReadLine());

            // Condicional definido para la edad
            if (edad < 18) Console.WriteLine("No puedes conducir");
            else
            {
                Console.WriteLine("¿Tienes carnet? si/no");
                string carnet = Console.ReadLine();

                int compara = string.Compare(carnet, "si", true);

                if (compara == 0) Console.WriteLine("Puedes conducir vehiculos");

                else Console.WriteLine("Lo siento, no puedes conducir");
            }
        }
    }
}
