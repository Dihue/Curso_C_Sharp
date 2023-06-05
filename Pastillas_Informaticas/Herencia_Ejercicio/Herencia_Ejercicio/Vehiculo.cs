using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejercicio
{
    internal class Vehiculo
    {
        public void ArrancarMotor()
        {
            Console.WriteLine("El motor está encendido");
        }

        public void PararMotor()
        {
            Console.WriteLine("El motor está apagado");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Este el el código genérico para el método Conducir");
        }
    }
}
