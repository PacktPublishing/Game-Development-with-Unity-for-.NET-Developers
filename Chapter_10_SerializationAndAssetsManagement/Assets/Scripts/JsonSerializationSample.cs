using UnityEngine;
using Newtonsoft.Json;

public class JsonSerializationSample : MonoBehaviour
{
    private void Start()
    {
        var playerData = new PlayerData("player1", 50, 100, 100);
        var jsonString = JsonUtility.ToJson(playerData);
        Debug.Log(jsonString);
        var deserializedObject = JsonUtility.FromJson<PlayerData>(jsonString);
        Debug.Log(deserializedObject.Name);
    }
}


