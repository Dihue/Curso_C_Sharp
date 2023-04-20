using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Interfaces
{
    interface IJugador
    {
        void correr();
        void pasar();
    }

    abstract class Deporte : IJugador
    {
        public void correr() { }

        public void pasar() { }
    }

    class Futbol : Deporte
    {
        public void correr()
        {
            Console.WriteLine("Correr en la cancha");
        }

        public void pasar()
        {
            Console.WriteLine("Hace un pase al compañero");
        }
    }

    class Basquet : Deporte
    {
        public void correr()
        {
            Console.WriteLine("Correr en la cancha de parquet");
        }

        public void pasar()
        {
            Console.WriteLine("Hace un pase al compañero con una mano");
        }
    }

    class Equipo
    {
        public void entrenar(IJugador d)
        {
            d.correr();
            d.pasar();
        }
    }

    class Programador : IJugador
    {
        public void correr()
        {
            Console.WriteLine("Correr en la cancha como pueda");
        }

        public void pasar()
        {
            Console.WriteLine("Intenta hacer un pase al compañero");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo();

            equipo.entrenar(new Futbol());
            equipo.entrenar(new Basquet());

            equipo.entrenar(new Programador());

            Console.ReadKey();
        }
    }
}
