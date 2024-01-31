namespace MathGame.Models;

internal class Game
{
    internal int Score { get; set; }
    internal GameType Type { get; set; }

    internal Difficulty Difficulty { get; set; }

    internal Game(int score, GameType type, Difficulty difficulty)
    {
        Score = score;
        Type = type;
        Difficulty = difficulty;
    }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

internal enum Difficulty
{
    Easy,
    Medium,
    Hard
}