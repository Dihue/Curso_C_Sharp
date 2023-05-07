/*
 * Principio de Sustitución en la herencia : Diseño de Herencia
 * (class ... es siempre un... class)
 * Ayuda en la jerarquía de la Herencia
 */
namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación de instancias de las distintas clases
            Caballo caballo = new Caballo("Spirit");
            Humano humano = new Humano("Pepe");
            Gorilla gorilla = new Gorilla("King Kong");

            Console.WriteLine("\nCaballo: " + caballo.NombreSerVivo);
            caballo.Galopar();
            Console.WriteLine("\nHumano: " + humano.NombreSerVivo);
            humano.Pensar();
            Console.WriteLine("\nGorila: " + gorilla.NombreSerVivo);
            gorilla.Trepar();

            Console.WriteLine("\n<- - - Principio de Sustitución - - ->\n");
            // Principio de Sustitución
            // Solo pueden acceder a los métodos declarados en la clase Mamífero
            Mamifero animal = new Caballo("Ponyta");
            Mamifero persona = new Humano("Juan");

            // Uso en arrays
            Mamifero[] almacenAnimales = new Mamifero[5];

            almacenAnimales[0] = caballo;
            almacenAnimales[1] = humano;
            almacenAnimales[2] = gorilla;
            almacenAnimales[3] = animal;
            almacenAnimales[4] = persona;

            // Solo se tiene acceso a los métodos de la clase definida (Mamiferos)
            almacenAnimales[1].Respirar();
            Console.WriteLine(almacenAnimales[3].NombreSerVivo);

        }
    }
}