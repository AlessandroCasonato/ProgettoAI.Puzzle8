using ProgettoAI.Puzzle8.Core;
using ProgettoAI.Puzzle8.Core.Models;
using System.Runtime.InteropServices;
using static ProgettoAI.Puzzle8.Core.Utilities;

namespace ProgettoAI.Puzzle8.FormApp
{
    public partial class Form1 : Form
    {
        private Game game;
        private Button[] grid;
        public Form1()
        {
            AllocConsole();
            InitializeComponent();
            game = new();
            grid = new Button[9] { tile0Btn, tile1Btn, tile2Btn, tile3Btn, tile4Btn, tile5Btn, tile6Btn, tile7Btn, tile8Btn };
            renderTiles();
            renderState();
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void startBtn_Click(object sender, EventArgs e)
        {
            startSearch();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            game = new Game();
            renderTiles();
            renderState();
        }

        private void renderTiles()
        {
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i].Text = game.ActualState.Tiles[i].ToString();
                if (game.ActualState.Tiles[i] == Utilities.FinalTiles[0])
                    grid[i].BackColor = Color.LightYellow;
                else if (game.ActualState.Tiles[i] == Utilities.FinalTiles[i])
                    grid[i].BackColor = Color.LightGreen;
                else
                    grid[i].BackColor = Color.LightGray;
            }
        }
        private void renderState()
        {
            stateTextBox.Text = game.ActualState.ToString();
        }

        private async void startSearch()
        {
            stepBtn.Enabled = false;
            var solution = await IterativeDeepeningAStarSearch(game);
            var solutionList = solution.PreviousStates;
            solutionList.Reverse();
            solutionList.Add(solution);
            game.SolutionSteps = solutionList.ToArray();
            stepBtn.Enabled = true;
        }

        private void stepBtn_Click(object sender, EventArgs e)
        {
            if (game.SolutionIndex < game.SolutionSteps.Length - 1)
            {
                game.SolutionIndex++;
                game.ActualState = game.SolutionSteps[game.SolutionIndex];
                renderTiles();
                renderState();
            }
            else
            {
                game.SolutionIndex++;
                game.ActualState = game.SolutionSteps[game.SolutionIndex];
                renderTiles();
                renderState();
                stepBtn.Enabled = false;
                MessageBox.Show("Configurazione finale ottenuta");
            }
        }
    }
}