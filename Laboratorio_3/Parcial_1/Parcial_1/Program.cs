namespace Parcial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Llamada de la pregunta 1
            Pregunta_1 pregunta_1 = new Pregunta_1();
            Console.WriteLine("\n<- - - - - Resolución pregunta 1 - - - - ->");
            pregunta_1.suma();

            // Pregunta 3
            Console.WriteLine("\n<- - - - - Resolución pregunta 3 - - - - ->");
            Console.WriteLine("\n VECTOR");

            int[] m2 = new int[2];
            IMatriz mat2 = new MatrizLineal(m2);
            mat2.mostrar();

            Console.WriteLine("\n VECTOR multiplicado por 2");
            Calcular c2 = new Calcular();
            c2.multiplica_x2(mat2);

            Console.WriteLine("\n MATRIZ");
            int[,] m = new int[2, 2];
            IMatriz mat = new MatrizCuadrada(m);
            mat.mostrar();

            Console.WriteLine("\n MATRIZ multiplicada por 2");
            Calcular c = new Calcular();
            c.multiplica_x2(mat);

            Console.ReadLine();

            // Pregunta 4
            Console.WriteLine("\n<- - - - - Resolución pregunta 4 - - - - ->");
            string nombre = "";
            Persona persona = new Estudiante(nombre);
            persona.Saludar();

            // Pregunta 5
            Console.WriteLine("\n<- - - - - Resolución pregunta 5 - - - - ->");
            Estudiante estudiante = new Estudiante("Juan");
            Console.WriteLine(estudiante.Nombre);
        }
    }
}