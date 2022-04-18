using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle
{
    internal class Nodo
    {
        public int funcionHeuristica { get; set; }
        public int funcionCosto { get; set; }
        public int funcionObjetivo { get; set; }
        public Tablero tablero { get; set; }
        public List<Nodo> hijos { get; set; }

        public Nodo(Tablero tablero)
        {
            this.tablero = tablero;
        }

        
    }
}
