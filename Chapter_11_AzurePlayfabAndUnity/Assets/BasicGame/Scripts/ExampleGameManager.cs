using UnityEngine;
using UnityEngine.SceneManagement;

public class ExampleGameManager : MonoBehaviour
{
	[SerializeField]
	private GameObject _obstaclePrefab;

	[SerializeField]
	private TextMesh _scoreLabel;

	[SerializeField]
	private AzurePlayFabLeaderboardManager _azurePlayFabLeaderboardManager;

	public static int score;
	
	public int Score
	{
		set
		{
			score = value;

			_scoreLabel.text = Score.ToString();
		}
		get
		{
			return score;
		}
	}

	public void GameOver()
    {
		_azurePlayFabLeaderboardManager.UpdateLeaderboardInAzurePlayFab(score);
		_azurePlayFabLeaderboardManager.LoadLeaderboardDataFromAzurePlayFab();
		//SceneManager.LoadScene(1);
    }

	private void Start () 
	{
		score = 0;
		InvokeRepeating("CreateObjects", 1,2);
	}

	private void CreateObjects()
	{
		if(_obstaclePrefab == null)
        {
			return;
        }

		Instantiate(_obstaclePrefab, new Vector3(7.5f, Random.Range(-2f, 2.1f) , 0) , Quaternion.identity);
	}
}
