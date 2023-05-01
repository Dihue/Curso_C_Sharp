/*
 * Encapsulación y convenciones
 */

namespace Ejemplo_POO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración e Instancia de clase
            Circulo miCiruculo = new Circulo();

            // Salida por consola
            Console.WriteLine("Área de un círculo: " + miCiruculo.CalculoArea(5));

            ConversorEuroDolar objeto = new ConversorEuroDolar();
            Console.WriteLine("\nU$s: " + objeto.Convierte(50));

            objeto.CambiarValorEuro(1.45);
            Console.WriteLine("\nU$s: " + objeto.Convierte(50));

            objeto.CambiarValorEuro(-1.45);
            Console.WriteLine("\nU$s: " + objeto.Convierte(50));
        }
    }

    // Creación de una clase
    class Circulo
    {
        // Campo de clase
        private const double PI = Math.PI;
        /*
         * private es usado para que la constante no sea accedida desde otra clase
         * hacer esto es el ENCAPSULAMIENTO del campo
         */

        // Método de clase
        public double CalculoArea(int radio)
        {
            // Round (valor a redondear, número de dígitos)
            return Math.Round((PI * radio * radio), 4);
        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.24;

        public double Convierte(double cantidad)
        {
            return euro * cantidad;
        }

        public void CambiarValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.24;
            else euro = nuevoValor;
        }
    }
}