using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_1
{
    internal class Caballo : Mamifero, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        // Constructor
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {
            
        }

        // Método de clase
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        // Métodos que provienen de las interfaces
        // Se debe quitar el modificador de acceso public para identificar de donde viene
        int IMamiferosTerrestres.NumeroDePatas()
        {
            return 4;
        }

        // Al tener método del mismo nombre pero que vienen de distintas interfaces
        int ISaltoConPatas.NumeroDePatas()
        {
            return 2;
        }

        public string TipoDeporte()
        {
            return "Carrera de caballos";
        }

        public bool EsOlimpico()
        {
            return false;
        }

    }
}
