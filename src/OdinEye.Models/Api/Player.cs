namespace OdinEye.Models.Api;

using System;

public class Player
{
    public Guid Id { get; set; }
    public string CharacterId { get; set; }
    public string SteamId { get; set; }
    public string Name { get; set; }
    public float Health { get; set; }
    public float MaxHealth { get; set; }
    public float Stamina { get; set; }
}