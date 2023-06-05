/*
 * Creación de tres clases:
 *      Avión
 *      Vehículo
 *      Coche
 * 
 * Métodos comunes a las tres clases:
 *      Arrancar motor
 *      Parar motor
 * 
 * Método virtual:
 *      Conducir
 */

namespace Herencia_Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n- - - Probando el avión - - -");
            Avion avion = new Avion();
            avion.ArrancarMotor();
            avion.PararMotor();
            avion.Conducir();

            Console.WriteLine("\n- - - Probando el coche - - -");
            Coche coche = new Coche();
            coche.ArrancarMotor();
            coche.PararMotor();
            coche.Conducir();

            Console.WriteLine("\n- - - Polimorfismo en acción - - -\n");
            Vehiculo miVehiculo = coche;

            miVehiculo.Conducir();

            miVehiculo = avion;

            miVehiculo.Conducir();
        }
    }
}