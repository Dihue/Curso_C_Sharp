using System;

/*
 * Declaración de variables booleanas
 * Uso de operadores booleanos
 * Conficional IF
 */
namespace Condicional_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variable booleana
            bool haceFrio = false;

            Console.WriteLine("Original: " + haceFrio);

            // Operador negación !
            Console.WriteLine("Negado: " + !haceFrio);


            int edad = 15;

            Console.WriteLine("\nVamos a evaluar si eres mayor de edad");

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
        }
    }
}
