/*
 * Array implicitos
 * Asignación
 * Array anónimos
 * Bucle FOR
 */
namespace Ejemplo_Arrays_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array implícito
            // los datos pasados deben ser del mismo tipo
            var datos = new[] { "Argentina", "Uruguay", "Brazil" };
            var valores = new[] {12, 24, 56, 21.21, 35.35 }; // todo a double

            // Array de objetos
            Empleados[] arrayEmpleados = new Empleados[2];

            // Asignación y creación del objeto
            arrayEmpleados[0] = new Empleados("Virginia", 35);

            Empleados Ana = new Empleados("Ana", 23);
            arrayEmpleados[1] = Ana;

            // Arrays de tipos o clases anónimas
            var personas = new[]
            {
                new{ Nombre = "Juan", Edad = 45},
                new { Nombre = "Maria", Edad = 35 },
                new { Nombre = "Diana", Edad = 22 }
            };

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            Console.WriteLine("\nBucle Foreach");
            foreach (Empleados variable in arrayEmpleados)
            {
                Console.WriteLine(variable.Nombre);
            }
        }
    }

    class Empleados
    {
        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;
            this.Edad = edad;
        }

        private string nombre;
        private int edad;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}