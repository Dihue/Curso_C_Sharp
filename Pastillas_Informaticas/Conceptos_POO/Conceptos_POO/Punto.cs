using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos_POO
{
    internal class Punto
    {
        // Método de acceso estático
        public static int getContadorObjeto() => contadorObjetos;


        // Método para el cálculo de la distancia entre puntos
        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif,2) + Math.Pow(yDif, 2));
            return distanciaPuntos;
        }


        // Constructor con parámetros
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorObjetos++;
        }


        // Constructor por defecto con leve modificación
        public Punto()
        {
            this.x = 0;
            this.y = 0;
            contadorObjetos++;
        }


        // Campos
        private int x;
        private int y;
        private static int contadorObjetos = 0;
    }
}
