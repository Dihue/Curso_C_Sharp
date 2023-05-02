namespace Ejemplo_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de un array
            int[] edades;

            // Iniciación del array (con valores por defectos)
            edades = new int[4];

            // Asignación de valores del array
            edades[0] = 12;
            edades[1] = -43;
            edades[2] = 21;
            edades[3] = 91;

            Console.WriteLine(edades[2]);

            // Otra forma de sintaxis de un array
            int[] numeros = {12, 23, 34, 45};

            Console.WriteLine(numeros[3]);

            // unicamente en c# se puede hacer
            int[] otrosNumeros = new int [4] { 12, 23, 34, 45 };
        }
    }
}