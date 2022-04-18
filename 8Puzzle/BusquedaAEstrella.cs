using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle
{
    internal class BusquedaAEstrella
    {
        public int[,] matriz { get; set; }

        private Tablero tablero;
        
        private List<Nodo> nodosHoja = new();

        public BusquedaAEstrella(int[,] matriz)
        {
            this.matriz = matriz;
            tablero = new Tablero(matriz);
        }

        public Nodo generarArbol()
        {
            Nodo arbol = new(tablero);

            while (!determinarSolucion())
            {

            }

            return arbol;
        }

        private bool determinarSolucion()
        {
            return determinarMenorFuncionObjetivo();
        }

        private bool determinarMenorFuncionObjetivo()
        {
            bool esSolucion = true;
            int mayor = nodosHoja.First().funcionObjetivo;
            int menor = nodosHoja.Last().funcionObjetivo;

            if(nodosHoja != null)
            {
                foreach (var item in nodosHoja)
                {

                }
            }

            return true;
        }
    }
}
