using System.Collections.Generic;

public class TeamData
{
    public List<PlayerData> Players;
    public Dictionary<string, PlayerData> Roles;

    public TeamData()
    {
        Players = new List<PlayerData>();
        Roles = new Dictionary<string, PlayerData>();
    }
}
