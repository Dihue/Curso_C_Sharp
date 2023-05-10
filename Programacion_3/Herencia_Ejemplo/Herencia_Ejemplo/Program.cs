namespace Herencia_Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancias usando los dos constructores
            Car miAuto = new Car();
            Car miAuto2 = new Car(30);

            Console.WriteLine(miAuto.Speed);
            Console.WriteLine(miAuto2.Speed);

            /*
             * MiniVan hereda todos los miembros públicos
             * y el constructor por defecto solamente
             */
            MiniVan miVan = new MiniVan();
            Console.WriteLine(miVan.Speed);

            Console.ReadLine();
        }

        class Car
        {
            /*
             * READONLY: permite colocar el valor mientras o hasta que
             * lo instancie, solo una vez
             * 
             * Diferencia:
             *      Constante: se define en tiempo de compilación
             *      Readonly: se define en tiempo de ejecución
             */
            public readonly int maxSpeed;
            private int currSpeed;

            // Sobrecarga de Constructores
            public Car(int max)
            {
                this.maxSpeed = max;
                Speed = maxSpeed;
            }

            public Car()
            {
                maxSpeed = 55;
                Speed = maxSpeed;
            }

            // Método de clase
            public int Speed
            {
                get { return currSpeed; }
                set
                {
                    currSpeed = value;
                    if (currSpeed > maxSpeed)
                    {
                        currSpeed = maxSpeed;
                    }
                }
            }
        }

        class MiniVan : Car
        {

        }
    }
}