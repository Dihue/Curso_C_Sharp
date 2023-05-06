/*
 * Los ARRAYS son referencias a objetos, si modificas el contenido de un array
 * pasado por parámetro el cambio es visible en todas las referencias del array
 * fuera de ese método incluido en el array original
 */

namespace Ejemplo_Arrays_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración e instancias necesarias
            int[] numeros = new int[4];
            Random aleatorio = new Random();
            

            // Carga de números aleatorios en el array
            for (int i = 0; i < numeros.Length; i++)
            {
                int valor = aleatorio.Next(0, 10);
                numeros[i] = valor;
            }

            // Uso del método con el array como parámetro
            ProcesaDatos(numeros);

            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el main:");

            foreach (int i in arrayElementos)
            {
                Console.WriteLine(i);
            }
        }

        // Uso de array por parámetro
        static void ProcesaDatos(int[] datos)
        {
            // Recorrer elementos
            foreach (int dato in datos)
            {
                Console.WriteLine(dato + 10);
            }
        }

        // Uso de array como devolución de un método
        static int[] LeerDatos()
        {
            Console.WriteLine("\n¿Cuántos elementos quieres que tenga el array?");

            string respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);

            // Creamos un array de manera "dinámica"
            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posición {i}");

                respuesta = Console.ReadLine();
                int datosElementos = int.Parse(respuesta);

                datos[i] = datosElementos;
            }

            return datos;
        }
    }
}