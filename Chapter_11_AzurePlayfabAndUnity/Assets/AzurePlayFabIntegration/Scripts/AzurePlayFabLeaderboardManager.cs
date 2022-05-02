using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;

public class AzurePlayFabLeaderboardManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _leaderboardUIPanel;
    [SerializeField]
    private List<Text> _itemsText;

    public void UpdateLeaderboardInAzurePlayFab(int score)
    {
        var scoreUpdate = new StatisticUpdate
        {
            StatisticName = "UnityBookGame",
            Value = score
        };

        var scoreUpdateList = new List<StatisticUpdate> { scoreUpdate };

        var scoreRequest = new UpdatePlayerStatisticsRequest
        {
            Statistics = scoreUpdateList
        };

        PlayFabClientAPI.UpdatePlayerStatistics(scoreRequest, OnUpdateSuccess, OnError);
    }

    public void LoadLeaderboardDataFromAzurePlayFab()
    {
        var loadRequest = new GetLeaderboardRequest
        {
            StatisticName = "UnityBookGame",
            StartPosition = 0,
            MaxResultsCount = 10
        };

        PlayFabClientAPI.GetLeaderboard(loadRequest, OnLoadSuccess, OnError);
    }


    public void OnUpdateSuccess(UpdatePlayerStatisticsResult result) 
    {
        Debug.Log("Update Success!");
    }

    public void OnLoadSuccess(GetLeaderboardResult result)
    {
        _leaderboardUIPanel.SetActive(true);
        CreateRankingItemsInUnity(result.Leaderboard);
    }

    public void OnError(PlayFabError error) 
    {
        Debug.LogError(error.ErrorMessage);
    }

    private void CreateRankingItemsInUnity(List<PlayerLeaderboardEntry> items)
    {
        foreach(var item in items)
        {
            var itemText = _itemsText[item.Position];
            itemText.text = $"{item.Position + 1}: {item.Profile.DisplayName} - {item.StatValue}";
        }
    }
}
