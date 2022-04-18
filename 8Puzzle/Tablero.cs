using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle
{
    internal class Tablero
    {
        public int[,]  matriz { get; set; }

        private int[,] matrizObjetivo = new int[3, 3]
        {
            {-1, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
        };

        private Tablero tableroObjetivo;

        public Tablero(int[,] matriz)
        {
            this.matriz = matriz;
            tableroObjetivo = new Tablero(matrizObjetivo);
        }

        public bool determinarSolucion(Tablero tablero)
        {
            bool esSolucion = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(tablero.matriz[i,j] != tableroObjetivo.matriz[i, j])
                    {
                        esSolucion = false;
                    }
                }
            }

            return esSolucion;
        }
    }
}
