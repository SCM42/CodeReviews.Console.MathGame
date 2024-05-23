﻿namespace MathGame.Models;

internal class Game
{
    public DateTime Date { get; set; }
    
    public int Score { get; set; }

    public GameType Type { get; set; }

    public string? GameDifficulty { get; set; }

    public int Questions { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}