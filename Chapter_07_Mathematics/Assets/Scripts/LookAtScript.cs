using UnityEngine;

public class LookAtScript : MonoBehaviour
{
    [SerializeField] private Transform _target;

    void Update()
    {
        if (_target == null) return;
        var dir = _target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(dir);
    }
}
