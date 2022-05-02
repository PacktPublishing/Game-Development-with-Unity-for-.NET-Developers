using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed = 10f;
    [SerializeField] private bool _isPlayerOne;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var inputAxis = _isPlayerOne ? "PlayerOneMove" : "PlayerTwoMove";
        var direction = new Vector3( Input.GetAxis(inputAxis), 0, 0);
        _rigidbody.MovePosition(transform.position + direction * Time.deltaTime * _speed);
    }
}
