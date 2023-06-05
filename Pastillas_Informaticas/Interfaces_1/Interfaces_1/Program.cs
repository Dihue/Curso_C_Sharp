namespace Interfaces_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancias de las clases
            Ballena ballena = new Ballena("Lu");
            Caballo caballo = new Caballo("Tornado");
            Gorilla gorilla = new Gorilla("King Kong");
            Humano humano = new Humano("Pepe");

            // Utilizamos el principio de sustitución "es-un"
            // Para poder llamar al método que necesitemos de NumeroDePatas
            ISaltoConPatas miCaballo = caballo;

            Console.WriteLine("\n- - - Ballena - - -");
            ballena.Nadar();

            Console.WriteLine("\n- - - Caballo - - -");
            caballo.Galopar();
            Console.WriteLine("Patas con las que salta: " + miCaballo.NumeroDePatas());
        }
    }
}