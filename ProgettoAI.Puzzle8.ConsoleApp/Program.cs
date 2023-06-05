// See https://aka.ms/new-console-template for more information
using ProgettoAI.Puzzle8.Core.Models;
using static ProgettoAI.Puzzle8.Core.Utilities;


Game game = new();
var gamePath = await IterativeDeepeningAStarSearch(game);

/*
foreach (var state in gamePath.States)
{
    Console.WriteLine(state.ToString());
}
*/