using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
	[SerializeField]
	private Rigidbody2D _rigidbody2D;

	[SerializeField]
	private ExampleGameManager _gameManager;

	private bool _dead;

	private void Start()
	{
		_dead = false;
		if(_rigidbody2D == null)
        {
			_rigidbody2D = GetComponent<Rigidbody2D>();
        }
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0) && !_dead)
		{
			RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			
			if(hit.collider == null)
			{
				Jump();
			}
		}
	}

	private void Jump()
	{
		_rigidbody2D.velocity = Vector2.zero;
		_rigidbody2D.AddForce(Vector2.up * 200);
	}

	private void OnTriggerEnter2D(Collider2D col) 
	{
		if (!_dead)
		{
			if (col.tag == "Score")
			{
				_gameManager.Score++;
				Destroy(col.gameObject);
			}
			else if (col.tag == "Finish")
			{
				_dead = true;
				Invoke("Finish", 1.5f);
			}
		}
	}

	private void Finish()
	{
		_gameManager.GameOver();
	}
}
