/*
 * Expresiones checked y unchecked (solo funciona con tipos int long)
 * Configuración de excepciones
 * Lanzamiento de excepciones con throw
 */

namespace Excepciones_throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numero = int.MaxValue;
            /*
             * La reasultado de la suma es un valor erroneo, por lo que se utiliza
             * la expresión "checked" delante para lanzar la excepción de overflow
             * que es lo que realmente está pasando
             */
            int resultado = checked(numero + 20);
            
            // Caso contrario se usa unchecked
            int resultadoUnchecked = unchecked(resultado + 20);
            Console.WriteLine(resultado);
            

            Console.WriteLine("\nIntroduce número del mes");
            int NumeroMes = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(NombreDelMes(NumeroMes));
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje: " + ex.Message);
            }
            
            Console.WriteLine("Aquí continua el programa");
        }

        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}