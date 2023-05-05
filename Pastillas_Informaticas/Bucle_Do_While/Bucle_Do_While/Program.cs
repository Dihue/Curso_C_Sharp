using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * do-while = "haz-mientras"
 * Ejecuta el código en su interior al menos una vez
 */

namespace Bucle_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 9;

            do
            {
                Console.WriteLine("Impresión: " + z);
                z++;

            } while (z < 15);

            Console.WriteLine("----------------------------------");

            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);

            int miNumero, intentos = 0;

            Console.WriteLine("Introduce un número entre el 0 y el 100:");

            do
            {
                intentos++;
                miNumero = int.Parse(Console.ReadLine());

                if (miNumero > aleatorio) Console.WriteLine("El número es más bajo");
                if (miNumero < aleatorio) Console.WriteLine("El número es más alto");

            } while (aleatorio != miNumero);

            Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");
        }
    }
}
