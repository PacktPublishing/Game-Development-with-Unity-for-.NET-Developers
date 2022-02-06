using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float _speed;

    private void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
