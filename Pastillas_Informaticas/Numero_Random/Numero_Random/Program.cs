using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numAleatorio = numero.Next(0, 101);

            
            Console.WriteLine("\t- - - ADIVINAR EL NÚMERO - - -\n" +
                "Introduce un número entre el 0 y el 100:");
            int nuevoNum = int.Parse(Console.ReadLine());

            int contador = 1;

            while (numAleatorio != nuevoNum)
            {
                contador++;

                if (numAleatorio > nuevoNum)
                {
                    Console.WriteLine("Introduce un número mayor: ");
                    nuevoNum = int.Parse(Console.ReadLine());
                }
                if (numAleatorio < nuevoNum)
                {
                    Console.WriteLine("Introduce un número menor: ");
                    nuevoNum = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"\nNúmero Aleatorio: {numAleatorio}" +
                $"\nNúmero Introducido: {nuevoNum}" +
                $"\nIntentos: {contador}");
        }
    }
}
