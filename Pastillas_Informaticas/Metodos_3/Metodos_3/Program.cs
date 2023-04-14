using System;

// Métodos en C# que devuelven "cosas" (return)

namespace Metodos_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sumarNumeros(3, 7);

            Console.WriteLine("\nResultado de la suma: " + sumarNumeros(3, 7));

            Console.WriteLine("\nResultado de la división: " + divisionNumeros(3, 7));
        }

        // Método que devuelve un valor del tipo entero
        static int sumarNumeros(int num1, int num2)
        {
            return num1 + num2;
        }

        // Sólo en el caso de que el método tenga una línea de código
        static double divisionNumeros(double num1, double num2) => num1 / num2;
        
    }
}
