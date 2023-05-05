namespace Excepcion_Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;
                int contador = 0;
                string path = @"C:\\Users\\Dihue\\Desktop\\Repositories\\Curso_C_Sharp\\Pastillas_Informaticas\\Excepcion_Finally\\texto.txt";

                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en lectura");
            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                    Console.WriteLine("Se cerró fichero");
                }
            }
        }
    }
}