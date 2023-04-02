namespace EstructurasDecision
{
    internal class Program
    {
        /*
         * OBJETIVO: Comprender la aplicación de las estructuras
         * de decisión
         * 
         * - Cree una aplicación de consola
         * - Solicite el ingreso de un texto y controle que no
         *   esté vacío
         * - Despliegue un menú que muestre 3 opciones:
         *      Texto en mayúsculas
         *      Texto en minúsculas
         *      Texto original
         * - Capture la entrada con Console.Readkey y realice la
         *   opción solicitada
         */
        static void Main(string[] args)
        {
            Console.Title = "Estructuras de Decisión";

            string text;
            ConsoleKeyInfo option;

            do
            {
                Console.WriteLine("Ingrese texto:");
                text = Console.ReadLine();

            } while (text == " ");

            Console.WriteLine("\nSeleccione opcíon para ver el texto:");
            Console.WriteLine("F1 - Texto original");
            Console.WriteLine("F2 - Texto en mayúsculas");
            Console.WriteLine("F3 - Texto en minúsculas");

            option = Console.ReadKey();

            switch (option.Key)
            {
                case ConsoleKey.F1:
                    Console.WriteLine($"\nTexto: {text}"); break;

                case ConsoleKey.F2:
                    Console.WriteLine($"\nTexto: {text.ToUpper()}"); break;
                
                case ConsoleKey.F3:
                    Console.WriteLine($"\nTexto: {text.ToLower()}"); break;
            }
        }
    }
}