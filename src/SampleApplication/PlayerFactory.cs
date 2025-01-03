﻿using SampleApplication.Info;

namespace SampleApplication;

/// <summary>
/// Factory player information class
/// </summary>
public class PlayerFactory
{
    /// <summary>
    /// Create Player
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static PlayerInfo CreatePlayer(int number)
    {
        Console.Write($"プレイヤー{number}の名前を入力してください: ");
        var name = Console.ReadLine();
        return new PlayerInfo(name ?? "Unkown");
    }

    /// <summary>
    /// Create a player list
    /// </summary>
    /// <param name="count">Number of players to create</param>
    /// <returns></returns>
    public static List<PlayerInfo> CreatePlayers(int count)
    {
        var players = new List<PlayerInfo>();

        for (var i = 1; i <= count; i++)
        {
            players.Add(CreatePlayer(i));
        }

        return players;
    }
}