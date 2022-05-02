using UnityEngine;

public class SetScore : MonoBehaviour 
{
	public TextMesh bestScoreLabel;
	public TextMesh scoreLabel;

	void Start () 
	{
		scoreLabel.text = "Score: " + ExampleGameManager.score.ToString();

		if (ExampleGameManager.score > 0)
		{
			if (PlayerPrefs.GetInt("Score", 0) < ExampleGameManager.score)
			{
				PlayerPrefs.SetInt("Score", ExampleGameManager.score);
				PlayerPrefs.Save();
			}
		}

		bestScoreLabel.text = "HighScore: " + PlayerPrefs.GetInt("Score", 0).ToString();
		ExampleGameManager.score = 0;
	}
}