namespace Ejemplo_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación de objeto del tipo Circulo. Variable/objeto de tipo Circulo
            Circulo miCirculo;

            // INSTANCIA de la clase Circulo. Iniciación de variable/objeto de tipo Circulo
            miCirculo = new Circulo();

            Console.WriteLine(miCirculo.calculoArea(5));
            
            // Declaración e instanciación de un objeto de tipo Circulo
            Circulo otroCirculo = new Circulo();
        }

        class Circulo
        {
            // Campos de clase - Propiedades
            const double PI = Math.PI;

            // Métodos de clase - Comportamientos
            public double calculoArea(int radio)
            {
                double resultado = PI * radio * radio;

                return Math.Round(resultado,4);
            }
        }

    }
}