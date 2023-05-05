using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ¿Que son las excepcions?
 * Las excepciones son errores en tiempo de ejecución del programa que escapan al
 * control del programador
 * 
 * Tipos:   Memoria corrupta        Sectores defectuosos del disco
 *          Desbordamiento de pila  Acceso a ficheros inexistentes
 *          Conexiones a BBDD interrumpidas     ETC...
 *          
 * En el bloque try...catch es donde se le dice al programa que hacer si se presenta
 * un error, logrando que el programa pueda seguir su curso de ejecución y no se
 * cierre por completo
 * 
 * Herencia de Excepciones:
 * Exception -> SystemException -> FormatException, OverflowException, etc...
 */

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int miNumero = 101, intentos = 0;

            Console.WriteLine("Ingresa un número entero entre valores del 0 al 100");

            do
            {
                intentos++;

                try
                {
                    miNumero = int.Parse(Console.ReadLine());
                }
                // Las excepciones van ubicadas desde las más específicas a las más genéricas
                catch (FormatException ex)
                {
                    Console.WriteLine("No ha introducido un valor númerico inválido" +
                        $"\nSu último número ingresado es {miNumero}" +
                        " y puede continuar desde ahí");
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("No ha introducido un valor númerico inválido" +
                        $"\nSu último número ingresado es {miNumero}" +
                        " y puede continuar desde ahí");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha habido un error");
                }

                /*
                 * Captura de error con filtro
                 * catch (Exception ex) when (ex.GetType() != typeof(FormatException)
                 */

                if (miNumero < aleatorio) Console.WriteLine("\nEl número es MAYOR al ingresado");

                if (miNumero > aleatorio) Console.WriteLine("\nEl número es MENOR al ingresado");

            } while (aleatorio != miNumero);

            Console.WriteLine($"Correcto! Has usado {intentos} intentos para adivinar");
        }
    }
}
