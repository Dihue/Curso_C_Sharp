using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio
{
    internal class Coche : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Puede conducir un coche");
        }
    }
}
