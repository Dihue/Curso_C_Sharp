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
        }
    }
}