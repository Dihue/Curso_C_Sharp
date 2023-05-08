/*
 * Herencia de Métodos
 * -> Palabras reservadas "new", "virtual" y override"
 *      NEW: es para ocultar advertencia del uso del mismo método (igual en todo)
 *      que viene de la superclass y se lo declara en la clase heredada
 *      
 * POLIMORFISMO:
 *      es la capacidad que tienen los objetos, en programación, a comportarse de
 *      diferentes formas o a tener diferente forma, dependiendo del contexto en
 *      el que se encuentre dicho objeto
 * 
 * PROTECTED:
 *      se usa en los métodos que solo pueden ser accedido por la clase donde se
 *      lo definió y por las clases que heredan de esa superclass, pero no puede
 *      ser accedido por otras clases (como la clase Main del programa)
 */
namespace Herencia_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancias de las distintas clases
            Caballo caballo = new Caballo("Tornado");
            Humano humano = new Humano("Sergio");
            Gorilla gorilla = new Gorilla("King Kong");

            // Array de Mamíferos
            Mamifero[] almacenMamiferos = new Mamifero[3];

            almacenMamiferos[0] = caballo;
            almacenMamiferos[1] = humano;
            almacenMamiferos[2] = gorilla;

            Console.WriteLine("\nNombre: " + almacenMamiferos[0].Nombre);
            
            Console.WriteLine("\nNombre: " + almacenMamiferos[1].Nombre);

            Console.WriteLine("\nNombre: " + almacenMamiferos[2].Nombre);

            for (int i = 0; i < almacenMamiferos.Length; i++)
            {
                almacenMamiferos[i].Pensar();
            }

        }
    }
}