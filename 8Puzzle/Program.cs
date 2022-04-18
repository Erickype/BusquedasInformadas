// See https://aka.ms/new-console-template for more information
using _8Puzzle;

int[,] matriz = new int[3, 3]
        {
            {7, 2, 4},
            {5, -1, 6},
            {8, 3, 1}
        };

BusquedaAEstrella busquedaAEstrella = new BusquedaAEstrella(matriz);

Nodo arbolResultado = busquedaAEstrella.generarArbol();

Console.Write(arbolResultado);
