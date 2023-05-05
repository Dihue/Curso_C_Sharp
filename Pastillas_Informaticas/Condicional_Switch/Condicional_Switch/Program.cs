using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Uso de switch
 * 
 * Cada expresión constante ha de ser única (luego del case)
 * Solo se puede evaluar: int, char o string
 * Los case solo pueden contener expresiones constantes
 * Todos los case deben llevar su break
 */

namespace Condicional_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige un medio de transporte (coche,tren, avion");

            string medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {
                case "coche":
                    Console.WriteLine("Velocidad media 110 km/hs");
                    break;

                case "tren":
                    Console.WriteLine("Velocidad media 240 km/hs");
                    break;

                case "avion":
                    Console.WriteLine("Velocidad media 600 km/hs");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }
            Console.WriteLine("Fin programa");
        }
    }
}
