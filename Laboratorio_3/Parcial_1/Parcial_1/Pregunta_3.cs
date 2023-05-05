using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    interface IMatriz
    {
        void mostrar();
        void multiplica_x_escalar(int n);
    }

    class MatrizLineal : IMatriz
    {
        int[] m;

        public MatrizLineal(int[] m)
        {
            this.m = m;
            cargaAleatoria();
        }

        public void cargaAleatoria()
        {
            Random rand = new Random();

            for (int i = 0; i < m.Length; i++)
            {
                m[i] = rand.Next(0, 30);
            }
        }

        public void mostrar()
        {
            foreach (var item in m)
            {
                Console.WriteLine(" " + item);
            }
        }

        public void multiplica_x_escalar(int n)
        {
            foreach (var item in m)
            {
                Console.WriteLine(" " + item * 2);
            }
        }
    }

    class MatrizCuadrada : IMatriz
    {
        int[,] m;
        int I = 0;

        public MatrizCuadrada(int[,] m)
        {
            this.m = m;
            I = m.Length / 2;
            Random rand = new Random();

            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < I; j++)
                {
                    m[i, j] = rand.Next(00, 30);
                }
            }
        }

        public void mostrar()
        {
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < I; j++)
                {
                    Console.WriteLine(" " + m[i,j].ToString("00"));
                }
                Console.WriteLine();
            }
        }

        public void multiplica_x_escalar(int n)
        {
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < I; j++)
                {
                    Console.WriteLine(" " + (n * m[i, j]).ToString("00"));
                }
                Console.WriteLine();
            }
        }
    }

    class Calcular
    {
        IMatriz a;

        public void multiplica_x2(IMatriz a)
        {
            a.multiplica_x_escalar(2);
        }
    }

    internal class Pregunta_3
    {

    }
}
