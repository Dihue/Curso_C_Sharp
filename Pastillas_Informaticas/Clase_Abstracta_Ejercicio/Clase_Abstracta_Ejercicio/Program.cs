namespace Clase_Abstracta_Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lagartija lagartija = new Lagartija("Juancho");

            Console.WriteLine("\n- - - Lagartija - - -");
            lagartija.Respirar();
            lagartija.GetNombre();

            Caballo caballo = new Caballo("Tornado");
            Console.WriteLine("\n- - - Caballo - - -");
            caballo.Respirar();
            caballo.GetNombre();
        }
    }
}