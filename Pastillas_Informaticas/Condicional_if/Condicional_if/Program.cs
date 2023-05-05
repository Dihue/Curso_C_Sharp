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

            Console.WriteLine("\nIntroduce tu edad:");
            // El ReadLine leer strings, por lo que debemos cambiar el tipo de dato
            // en este caso, se usa el método Parse
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("\n¿Tienes carnet? Si/No");
            string carnet = Console.ReadLine();

            

            if (edad >= 18 && carnet == "Si")
            {
                Console.WriteLine("Puedes conducir");
            }
            else
            {
                Console.WriteLine("No puedes conducir");
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Vamos a evaluar si puedes conducir");

            bool carnet2 = false;

            if (carnet2) 
            {
                Console.WriteLine("Puedes conducir");
            }
            else
            {
                Console.WriteLine("Lo siento, no puedes condicir");
            }
        }
    }
}
