namespace Sintaxis_Basica_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración e iniciación de una CONSTANTE
            const int VALOR = 5;
            const int VALOR2 = 7;

            // Atajo mediante cw para el Console.WriteLine
            Console.WriteLine("El valor de la constante es {0}", VALOR, VALOR2);
            // {0} refleja el valor almacenado en el primer parámetro
            Console.WriteLine("El valor de la constante es {1}", VALOR, VALOR2);
            // {1} refleja el valor almacenado en el segundo parámetro


            // Ejemplo: cálculo del área de un círculo
            const double PI = Math.PI;

            Console.WriteLine("\nIntroduce el radio de la circunferencia: ");

            double radio = double.Parse(Console.ReadLine());

            double area = radio * radio * PI;
            double areaMath = Math.Pow(radio, 2) * PI;

            Console.WriteLine($"El área del círculo es {area}");
            Console.WriteLine($"El área del círculo es {areaMath}");
        }
    }
}