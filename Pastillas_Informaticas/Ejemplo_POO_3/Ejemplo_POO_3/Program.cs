/*
 * CONSTRUCTORES
 * GETTERS Y SETTERS
 */
namespace Ejemplo_POO_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia
            // new es el que emplea al constructor de la clase
            Coche coche1 = new Coche();
            // con esto se da un estadio inicial del objeto coche

            // Otra instancia que comparten los mismo valores del constructor
            Coche coche2 = new Coche();
            Console.WriteLine("\n < - - - Coche 1 - - - > ");
            Console.WriteLine("Ruedas: " + coche1.getRuedas());
            Console.WriteLine("Largo: " + coche1.getLargo());
            Console.WriteLine(coche1.getExtras());

            // Instancia con el segundo constructor
            Coche coche3 = new Coche(4230.65,1850.30);
            coche3.setExtras(true, "Cuero");

            Console.WriteLine("\n < - - - Coche 3 - - - > ");
            Console.WriteLine("Ruedas: " + coche3.getRuedas());
            Console.WriteLine("Largo: " + coche3.getLargo());
            Console.WriteLine(coche3.getExtras());
        }
    }

    partial class Coche
    {
        // Campos de clase
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

        // Métodos de acceso a los campos
        public int getRuedas()
        {
            return ruedas;
        }

        // Métodos Getters
        public double getLargo()
        {
            return largo;
        }

        public string getExtras()
        {
            return "\n < - - - Extras del coche - - - >\nTapicería: "
                + tapiceria + "\nClimatizador: " + climatizador;
        }


        // Métodos Setters
        public void setLargo(double nuevoLargo)
        {
            largo = nuevoLargo;
        }

        public void setExtras(bool climatizador, string tapiceria)
        {
            // this es usado para referenciar a los campos de la clase
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }
    }
    partial class Coche
    {
        // Constructor de la clase
        public Coche()
        {
            ruedas = 4;
            largo = 3200.55;
            ancho = 1560.35;
            tapiceria = "Tela";
        }

        // Sobrecarga de Constructor
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }
    }
}