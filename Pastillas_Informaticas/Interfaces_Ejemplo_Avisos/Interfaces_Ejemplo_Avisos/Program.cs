namespace Interfaces_Ejemplo_Avisos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia con el constructor por defecto
            AvisosTrafico av1 = new AvisosTrafico();

            av1.MostrarAviso();

            // Instancia con el contructor completo
            AvisosTrafico av2 = new AvisosTrafico("Jefatura de Policia","Sanción de velocidad: $300", "05-06-2023");

            av2.MostrarAviso();
        }
    }
}