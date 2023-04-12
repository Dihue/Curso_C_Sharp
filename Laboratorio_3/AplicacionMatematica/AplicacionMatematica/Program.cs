namespace AplicacionMatematica
{
    internal class Program
    {
        /*
         * Realizar una aplicacion de tipo consola en C# que según la
         * opción escogida en un menú, permita mostrar la tabla de
         * multiplicar de un número ingresado por el usuario, o
         * solicitar que se ingresen dos números "a" y "b" para mostrar
         * las operaciones suma "a+b", resta "a-b", multiplicación "a*b",
         * divicion "a/b" y resto de "a%b"
         */
        static void Main(string[] args)
        {
            Console.WriteLine("- - - - - - - Menú - - - - - - -");
            Console.WriteLine(" 1 -> Tabla de múltiplicación de un número");
            Console.WriteLine(" 2 -> Operaciones matemáticas entre dos números");

            Console.WriteLine("\nIngrese opción:");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("\nIngrese el número:");
                    int table = int.Parse(Console.ReadLine());

                    Console.WriteLine($"\nTabla del {table}:");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"{table} * {i} = {table * i}");
                    }
                    break;
                case 2:
                    Console.WriteLine("\nIngrese primer número:");
                    int A = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nIngrese segundo número:");
                    int B = int.Parse(Console.ReadLine());

                    Console.WriteLine($"\nResultado de la SUMA: {A + B}");
                    Console.WriteLine($"Resultado de la RESTA: {A - B}");
                    Console.WriteLine($"Resultado de la MULTIPLICACION: {A * B}");
                    Console.WriteLine($"Resultado de la DIVISION: {A / B}");
                    Console.WriteLine($"Resultado del RESTO: {A % B}");
                    break;
                default:
                    Console.WriteLine("\nOpción incorrecta");
                    break;
            }
        }
    }
}