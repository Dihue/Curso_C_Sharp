using System;
using System.Linq;

/*
 * -> Implementar una función Moda, que reciba como valores una cantidad
 * indeterminada de enteros y devuelva la moda (estadística), el valor
 * Mínimo y el valor Máximo.
 * -> Invocar este método y mostrar los resultados por consola.
 * -> Elija los modificadores más adecuados.
 */

namespace ParametrosModa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada del usuario que determina el tamaño del arreglo
            Console.WriteLine("\nIntroduce la cantidad de valores enteros a ingresar: ");
            int cantidadValores = Convert.ToInt32(Console.ReadLine());
            int[] enteros = new int[cantidadValores];


            // Carga de los valores en el arreglo
            for (int i = 0; i < cantidadValores; i++)
            {
                Console.WriteLine($"\nIngrese {i + 1}º valor: ");
                enteros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Salida por pantalla con los resultados
            Console.WriteLine("\nResultados obtenidos:");
            Console.WriteLine("-> La moda es: " + Moda(enteros));
            Console.WriteLine("-> El valor mínimo es: " + enteros.Min());
            Console.WriteLine("-> El valor máximo es: " + enteros.Max());
        }

        // Función Moda que se le pasa un arreglo de enteros como argumento
        public static int Moda(int[] valores)
        {
            // Ordenar el array de menor a mayor
            Array.Sort(valores);

            // Declaración e iniciación de variables
            int maxima_repetida = 0;
            int repetida_actual = 0;

            // Declaración e iniciación del arreglo
            int moda = valores[0];

            for (int i = 0; i < valores.Length; i++)
            {
                /*
                 * Si el valor anterior analizado es igual al siguiente,
                 * incrementa el valor de la repetida
                 */
                if (i > 0 && valores[i - 1] == valores[i])
                {
                    repetida_actual++;
                }
                else
                {
                    repetida_actual = 1;
                }

                /*
                 * Si la moda actual tiene mayor repeticion que la mejor
                 * moda guardada, se actualiza la moda
                 */
                if (repetida_actual > maxima_repetida)
                {
                    maxima_repetida = repetida_actual;
                    moda = valores[i];
                }
            }
            return moda;
        }
    }
}
