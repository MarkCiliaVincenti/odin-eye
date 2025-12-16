namespace OdinEye.Coroutines;

using Extensions;
using Http;
using Models.Proto;
using System;
using System.Collections;
using UnityEngine;

public class GameStatsSnapshotCoroutine(HttpWebServer httpWebServer)
{
    public IEnumerator SendGameStatsSnapshotCoroutine()
    {
        while (true)
        {
            SendGameStatsSnapshot();
            yield return new WaitForSeconds(1f);
        }
    }

    private void SendGameStatsSnapshot()
    {
        var worldStats = new WorldStats
        {
            DayNumber = EnvMan.instance.GetCurrentDay(),
            DayCycle = EnvMan.instance.IsDay() ? "day" : "night"
        };

        var peers = ZNet.instance.GetAllPeers();
        var playerStats = peers.ToPlayerStats();

        var gameStatsSnapshot = new GameStatsSnapshot
        {
            CreatedDate = DateTime.UtcNow,
            PlayerStats = playerStats,
            WorldStats = worldStats
        };
        
        httpWebServer.BroadcastWebSocketMessage(gameStatsSnapshot);
    }
}