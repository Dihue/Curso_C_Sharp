namespace Sintaxis_Basica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de múltiples variables del mismo tipo
            int edadPersona1, edadPersona2, edadPersona3, edadPersona4;

            // Inicializa a todas las variables con el mismo valor
            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 21;

            Console.WriteLine(edadPersona3);

            // Declaración implícita de variable
            // Asigna en tiempo de ejecución el tipo de la variable
            // Pero luego ese valor asignado no puede ser modificado
            var edadPersosna5 = 25;

            Console.WriteLine(edadPersosna5);

            double temperatura = 34.9;
            int temperaturaMadrid;

            // Conversión explícita o Casting
            temperaturaMadrid = (int)temperatura;
            // en este caso se da la perdida de información o precisión
            // debido a que el valor double pierde su parte decimal
            Console.WriteLine("Temperatura: " + temperaturaMadrid);

            // Conversión implícita
            // entre tipos compatibles pero de distinto alcance
            int habitantesCiudad = 100000;
            long habitantesCiudad2023 = habitantesCiudad;
            Console.WriteLine(habitantesCiudad2023);

            // Otro ejemplo
            float pesoMaterial = 123.47F;
            double pesoMaterialPreciso = pesoMaterial;
            Console.WriteLine(pesoMaterialPreciso);

            // Ver tabla de conversiones numéricas para más ejemplos

            // Conversión de tipos (typeConverse)
            // de String a numérico y viceversa

        }
    }
}