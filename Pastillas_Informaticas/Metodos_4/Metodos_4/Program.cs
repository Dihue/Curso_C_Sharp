using System;

/*
 * Ambito o alcance de métodos y variables:
 *  este ámbito se da entre las llaves de un método o clase
 * Sobrecarga de métodos
 */
namespace Metodos_4
{
    internal class Program
    {
        // variables de clase (visibles en toda la clase)
        // Denominadas CAMPOS DE CLASE
        static int numero1 = 1;
        static int numero2 = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Variables de método");
            primerMetodo();
            Console.WriteLine("Campos de clase");
            segundoMetodo();
        }

        static void primerMetodo()
        {
            // variable visible de manera local
            int numero1 = 5;
            int numero2 = 3;

            // Uso de variables del método
            Console.WriteLine(numero1 + numero2);
        }

        static void segundoMetodo()
        {
            // Uso de variables de la clase
            Console.WriteLine(numero1 + numero2);
        }

        // expression-bodied =>
        static int suma(int operador1, int operador2) => operador1 + operador2;

        /* Para la sobrecarga de métodos se puede realizar mediante:
         * tener distinta cantidad de parámetros
         * tener distintos tipos de parámetros
         */
        static int suma(int operador1, int operador2, int operador3) => operador1 + operador2;

        static int suma(int operador1, double operador2) => operador1;
    }
}
