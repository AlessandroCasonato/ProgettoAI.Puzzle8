using ProgettoAI.Puzzle8.Core.Models;

namespace ProgettoAI.Puzzle8.Core
{
    public static class Utilities
    {
        public static int NodesOpened = 0;
        public enum HeuristicUsed
        {
            Rough,
            ManhattanDistance
        };
        public static readonly int[] FinalTiles = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        public static Dictionary<int, (int, int)> FinalTilesPosition = new()
        {
            {0, (0,0) },
            {1, (0,1) },
            {2, (0,2) },
            {3, (1,0) },
            {4, (1,1) },
            {5, (1,2) },
            {6, (2,0) },
            {7, (2,1) },
            {8, (2,2) },

        };

        public static Dictionary<(int, int), int> FinalTilesCoords = new()
        {
            {(0,0), 0 },
            {(0,1), 1 },
            {(0,2), 2 },
            {(1,0), 3 },
            {(1,1), 4 },
            {(1,2), 5 },
            {(2,0), 6 },
            {(2,1), 7 },
            {(2,2), 8 },

        };

        /// <summary>
        /// Funzione che genera una classe State iniziale generando una sequenza casuale di 9 tiles (da disporre poi in griglia)
        /// e ponendo come distanza stimata un valore dipendente dall'euristica usata per calcolarla
        /// </summary>
        /// <returns>Lo stato iniziale</returns>
        public static State GenerateInitialState()
        {
            int[] initialTiles = FinalTiles.OrderBy(x => Guid.NewGuid()).ToArray();
            int distanceEstimated = GetManhattanDistance(initialTiles);

            return new State()
            {
                Tiles = initialTiles,
                StepsDone = 0,
                DistanceEstimated = distanceEstimated,
                Cost = distanceEstimated,
            };
        }

        /// <summary>
        /// Funzione euristica che ritorna una stima della distanza dalla soluzione in base al numero di mosse
        /// che sarebbero richieste per spostare ogni tessera nello stato finale. Questa stima è ottenuta rilassando
        /// i vincoli poichè analizza ogni tessera singolarmente e non considera invece che ogni spostamento di 
        /// tessera causa lo spostamento di altre tessere.
        /// </summary>
        /// <param name="tiles">La configurazione di tessere da analizzare.</param>
        /// <returns>La stima della distanza dalla configurazione finale.</returns>
        public static int GetManhattanDistance(int[] tiles)
        {
            int distanceEstimated = 0;
            for (int i = 0; i < 9; i++)
            {
                // Posizione che dovrebbe assumere la casella secondo la configurazione finale
                var finalConfiguration = FromArrayToGridPosition(i);

                // Posizione che ha attualmente la casella (la posizione nel vettore tiles mi dice la sua posizione attuale)
                var initialConfiguration = FromArrayToGridPosition(tiles[i]);

                // Ottengo la distanza di Manhattan in base al valore assoluto della differenza delle singole coordinate
                distanceEstimated += Math.Abs(finalConfiguration.Item1 - initialConfiguration.Item1) +
                                      Math.Abs(finalConfiguration.Item2 - initialConfiguration.Item2);

            }
            return distanceEstimated;
        }

        /// <summary>
        /// Algoritmo di ricerca A* in profondità che usa come cutoff la somma di distanza stimata rimanente e i passi compiuti in
        /// maniera iterativa e incrementale. Ad ogni iterazione, il cutoff viene incrementato al valore più basso che ha superato
        /// il cutoff precedente.
        /// </summary>
        /// <param name="game">La classe di partenza "Game"</param>

        public static async Task<State> IterativeDeepeningAStarSearch(Game game)
        {
            var cutoff = game.ActualState.DistanceEstimated;
            while (cutoff < 100)
            {
                NodesOpened = 0;
                Console.WriteLine("Ciclo con cutoff: " + cutoff.ToString());
                var nodesToOpen = new List<State>() { game.ActualState };
                var newCutoff = int.MaxValue;
                while (nodesToOpen.Count > 0)
                {
                    NodesOpened++;
                    Console.WriteLine("Espando nodo " + NodesOpened + " con cutoff " + cutoff.ToString());
                    State nodeToOpen = null;
                    foreach (var node in nodesToOpen)
                    {
                        if (nodeToOpen == null)
                            nodeToOpen = node;
                        else if (node.Cost < nodeToOpen.Cost)
                            nodeToOpen = node;
                    }
                    Console.WriteLine("Configurazione attuale: " + nodeToOpen.ToString());
                    nodeToOpen.SelectNextStates();
                    foreach (var s in nodeToOpen.PossibleStates)
                    {
                        if (s.DistanceEstimated == 0)
                            return nodeToOpen;
                        else if (s.Cost <= cutoff)
                            nodesToOpen.Add(s);
                        else
                            newCutoff = s.Cost < newCutoff ? s.Cost : newCutoff;
                    }
                    nodesToOpen.Remove(nodeToOpen);
                }
                cutoff = newCutoff;
                }
            return null;
        }
           
        /// <summary>
        /// Funzione che converte la posizione di un elemento in un array nella coppia di coordinate corrispondente nella griglia
        /// </summary>
        /// <param name="i">Posizione nell'array dell'elemento</param>
        /// <returns>Coordinate nella griglia dell'elemento</returns>
            public static (int, int) FromArrayToGridPosition(int i)
        {
            return FinalTilesPosition[i];
        }

        /// <summary>
        /// Funzione che converte la posizione in coordinate nella griglia di un elemento nella corrispondente posizione nell'
        /// array di stato
        /// </summary>
        /// <param name="coords">Le coordinate attuali dell'elemento</param>
        /// <returns>La posizione corrispondente nell'array dell'elemento</returns>
        public static int FromGridPositionToArray((int x, int y) coords)
        {
            return FinalTilesCoords[coords];
        }
    }
}