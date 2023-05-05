using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_if_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Eres un niño");

            else if (edad < 30) Console.WriteLine("Eres jóven");

            else if (edad < 60) Console.WriteLine("Eres maduro");

            else Console.WriteLine("Debes cuidarte mucho");

            Console.WriteLine("--------------------------");

            Console.WriteLine("Introduce el primer parcial");
            float parcial1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo parcial");
            float parcial2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer parcial");
            float parcial3 = int.Parse(Console.ReadLine());

            if (parcial1>= 6 || parcial2>= 6 || parcial3>= 6)
            {
                Console.WriteLine("La nota media es " + (parcial1 + parcial2 + parcial3)/3);
            }
            else Console.WriteLine("Recursar materia");
        }
    }
}
