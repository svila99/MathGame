namespace MathGame.Models;

internal class Game
{
    internal int Score { get; set; }
    internal GameType Type { get; set; }

    internal Game(int score, GameType type)
    {
        Score = score;
        Type = type;
    }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}