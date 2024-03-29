﻿using MathGame.Models;

namespace MathGame;

internal class Helpers
{
    internal static List<Game> games = new List<Game>();


    internal static void AddScore(int score, GameType type, Difficulty difficulty)
    {
        games.Add(new Game(score, type, difficulty));
    }

    internal static void ViewScores()
    {
        var gamesToPrint = games.OrderByDescending(x => x.Score);
        Console.WriteLine("Game History");
        Console.WriteLine("---------------------------");
        Console.Clear();
        foreach (var game in gamesToPrint)
        {
            Console.WriteLine($"{DateTime.Now} {game.Type} game. {game.Difficulty} difficulty. Score({game.Score}/5) ");
        }

        Console.WriteLine("---------------------------");
        Console.ReadLine();
    }

    internal static string GetName()
    {
        Console.WriteLine("Please enter your name");
        var s = Console.ReadLine();
        while (string.IsNullOrEmpty(s))
        {
            Console.WriteLine("Empty name. Try again");
            s = Console.ReadLine();
        }

        return s;
    }


    public static string? ValidateInput(string? result)
    {
        while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
        {
            Console.WriteLine("Invalid input. Try again.");
            result = Console.ReadLine();
        }

        return result;
    }

    internal static Difficulty GetDifficultyEnum(string difficulty)
    {
        switch (difficulty)
        {
            case "E":
                return Difficulty.Easy;
            case "M":
                return Difficulty.Medium;
            case "H":
                return Difficulty.Hard;
            default:
                return Difficulty.Easy;
        }
        
    }
}