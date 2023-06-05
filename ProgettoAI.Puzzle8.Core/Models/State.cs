namespace ProgettoAI.Puzzle8.Core.Models
{
    public class State
    {
        public int StepsDone { get; set; }
        public int DistanceEstimated { get; set; }
        public int Cost { get; set; }
        public int [] Tiles { get; set; } = new int[9];
        public List<State> PossibleStates { get; set; }
        public List<State> PreviousStates { get; set; } = new();

        public override string ToString()
        {
            return "Passi eseguiti: " + StepsDone.ToString() + "\nDistanza stimata: " + DistanceEstimated.ToString();
        }

        /// <summary>
        /// Ritorna i possibili stati successivi in base alla posizione della casella vuota
        /// </summary>
        /// <returns>Una lista di stati successivi possibili dalla configurazione attuale</returns>
        public void SelectNextStates()
        {
            var emptyTilePos = Array.IndexOf(Tiles, 0);
            PossibleStates = new List<State>();
            
            // Posizione che ha attualmente la casella (la posizione nel vettore tiles mi dice la sua posizione attuale)
            var emptyTileGridPos = Utilities.FromArrayToGridPosition(emptyTilePos);
            var newStepsDone = this.StepsDone + 1;
            var tmpPossibleMoves = new (int, int)[4] {
                (emptyTileGridPos.Item1 + 1, emptyTileGridPos.Item2),
                (emptyTileGridPos.Item1 - 1, emptyTileGridPos.Item2),
                (emptyTileGridPos.Item1, emptyTileGridPos.Item2 + 1),
                (emptyTileGridPos.Item1, emptyTileGridPos.Item2 - 1),
            };
            foreach(var x in tmpPossibleMoves) {
                var previousStatePos = PreviousStates.Any() ? Array.IndexOf(PreviousStates.First().Tiles, 0) : -1;
                var previousStateCoords = previousStatePos != -1 ? Utilities.FromArrayToGridPosition(previousStatePos) : (-1, -1);
                
                //Controlliamo che sia una mossa valida e che non sia la posizione immediatamente precedente
                if (x.Item1 >= 0 && x.Item1 <= 2 && x.Item2 >= 0 && x.Item2 <= 2 && x != previousStateCoords)
                {
                    var newTiles = new int[9];
                    var tileToSwapPos = Utilities.FromGridPositionToArray((x.Item1, x.Item2));
                    for (int i = 0; i < 9; i++)
                    {
                        if (i == emptyTilePos)
                            newTiles[i] = Tiles[tileToSwapPos];
                        else if (i == tileToSwapPos)
                            newTiles[i] = Tiles[emptyTilePos];
                        else
                            newTiles[i] = Tiles[i];
                    }

                    var previousStates = new List<State>() { this };
                    var distanceEstimated = Utilities.GetManhattanDistance(newTiles);

                    PossibleStates.Add(new State()
                    {
                        Tiles = newTiles,
                        DistanceEstimated = distanceEstimated,
                        StepsDone = newStepsDone,
                        PreviousStates = previousStates.Concat(this.PreviousStates).ToList(),
                        Cost = distanceEstimated + newStepsDone
                    });
                }
            }
        }
    }
}
