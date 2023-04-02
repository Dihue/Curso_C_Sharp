namespace PrimerAplicacion
{
    internal class Program
    {
        /*
         * OBJETIVO: Comprender el uso de variables, asignaciones y
         * operaciones de forma simple en C#
         * 
         * - Cree una aplicación de consola
         * - Solicite el ingreso de dos valores por pantalla
         * - Al final, muestre en forma descriptiva los resultados
         * de aplicar las cuatro operaciones matemáticas básicas
         */

        static void Main(string[] args)
        {
            
            Console.WriteLine("\nIngresar el primer número");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngresar el segundo número");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" - - - - - - - - - - - - - - - ");
            Console.WriteLine($"\nEl resultado de la suma es {A + B}");
            Console.WriteLine($"\nEl resultado de la resta es {A - B}");
            Console.WriteLine($"\nEl resultado de la multiplicación es {A * B}");
            Console.WriteLine($"\nEl resultado de la división es {A / B}");
        }
    }
}