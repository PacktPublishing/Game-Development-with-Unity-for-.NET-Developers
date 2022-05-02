using UnityEngine;

public class PingPongBall : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Vector3 _initialImpulse;

    private void Start()
    {
        _rigidbody.AddForce(_initialImpulse, ForceMode.Impulse);
    }
}
