using static ProgettoAI.Puzzle8.Core.Utilities;

namespace ProgettoAI.Puzzle8.Core.Models
{
    public class Game
    {
        public State ActualState { get; set; }
        public int NodesOpened { get; set; }
        public State[] SolutionSteps { get; set; }
        public int SolutionIndex { get; set; }

        public Game() {
            ActualState = Utilities.GenerateInitialState();
            NodesOpened= 0;
            SolutionIndex = 0;
        }
    }
}
