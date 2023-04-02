namespace Sintaxis_Basica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir el primer número: ");
            // Conversión de string a int mediante la instrucción Parse
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introducir el segundo número: ");
            // Conversión de string a int mediante la instrucción Parse
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado es {num1 + num2}");
        }
    }
}