namespace Operadores_Aritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operaciones de manera directa

            // Multiplicación entre enteros y decimales
            Console.WriteLine(7 * 5);
            Console.WriteLine(7 * 5.2);

            // División entre enteros y decimales
            Console.WriteLine(7.0 / 5.0);
            Console.WriteLine(7.0 / 3);

            // Resto de una división
            Console.WriteLine(9 % 4);

            int edad = 10;
            // Usos del símbolo + como concatenador de Strings y Números
            Console.WriteLine("Tienes una edad de " + edad++ + " años");

            // Operador incremento como subfijo
            edad++;

            // Interpolación de Strings -> solo con C#
            Console.WriteLine($"Tienes una edad de {--edad} años");
        }
    }
}