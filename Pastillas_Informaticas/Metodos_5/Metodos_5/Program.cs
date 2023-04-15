using System;
/*
 * Ayudas de Visual Studio con métodos
 * Métodos con parámetros opcionales
 * Ambigüedades en llamadas a métodos
 */
namespace Metodos_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación de un método a partir de herramienta de VS
            Console.WriteLine(Suma(5,2.4));
            // Se escribe el nombre del método con sus parámetros antes de construirlo

            int valor1 = 2;
            double valor2 = 5.4;
            double valor3 = 8.1;

            Console.WriteLine("V1 + V2 = " + SumaOpcional(valor1,valor2));
            Console.WriteLine("V1 + V3 = " + SumaOpcional(valor1, valor3));
            Console.WriteLine("V1 + V2 + V3 = " + SumaOpcional(valor1, valor2, valor3));
        }

        /*
        private static bool Suma(int v1, double v2)
        {
            throw new NotImplementedException();
        }
        */

        // OPERADOR LAMDA =>
        private static double Suma(double x, double y) => x + y;

        // Método con parámetro opcional
        private static double SumaOpcional(int num1, double num2, double num3 = 0)
        {
            return num1 + num2 + num3;
        }
    }
}
