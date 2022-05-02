using UnityEngine;
using Newtonsoft.Json;

public class JsonUtilityLimitationsSample : MonoBehaviour
{
    private void Start()
    {
        var playerData = new PlayerData("player1", 50, 100, 100);
        var teamData = new TeamData();
        teamData.Players.Add(playerData);
        teamData.Roles.Add("leader", playerData);

        // Serialize the objects with JsonUtility.
        var jsonStringFromTeamData = JsonUtility.ToJson(teamData);
        var jsonStringFromList = JsonUtility.ToJson(teamData.Players);

        // Serialize the objects with Newtonsoft.Json
        //var jsonStringFromTeamData = JsonConvert.SerializeObject(teamData);
        //var jsonStringFromList = JsonConvert.SerializeObject(teamData.Players);

        Debug.Log(jsonStringFromTeamData);
        Debug.Log(jsonStringFromList);
    }
}
