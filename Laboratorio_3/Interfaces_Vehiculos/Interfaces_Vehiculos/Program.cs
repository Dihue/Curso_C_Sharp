using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Vehiculos: supongamos que tienes una aplicacion que tiene una clase llamada
 * "Vehicle". Podras crear una interfaz llamada "IDriveable" que tenga un metodo
 * "Drive()" que todos los vehiculos deberian implementar. De esta manera, podrias
 * crear diferentes tipos de vehiculos que tengan su propia implementacion del
 * metodo Drive
 */
namespace Interfaces_Vehiculos
{
    interface IDriveable
    {
        void drive();
    }

    abstract class Vehiculo : IDriveable
    {
        public virtual void drive() { }
    }

    class Moto : Vehiculo
    {
        public override void drive()
        {
            Console.WriteLine("Tiene 2 ruedas");
        }
    }

    class Automovil : Vehiculo
    {
        public override void drive()
        {
            Console.WriteLine("Tiene 4 ruedas");
        }
    }

    class Camion : Vehiculo
    {
        public override void drive()
        {
            Console.WriteLine("Tiene 6 ruedas");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Moto();
            Vehiculo v2 = new Automovil();
            Vehiculo v3 = new Camion();

            v1.drive();
            v2.drive();
            v3.drive();
        }
    }
}
