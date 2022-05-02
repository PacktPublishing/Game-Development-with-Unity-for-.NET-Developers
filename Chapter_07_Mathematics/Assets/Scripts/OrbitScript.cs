using UnityEngine;

public class OrbitScript : MonoBehaviour
{
    [SerializeField] 
    private Transform _target;

    private void Update()
    {
        if (_target == null) return;

        var dir = _target.position - transform.position;

        var targetRotation = Quaternion.LookRotation(dir);
        var currentRotation = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(currentRotation, targetRotation, Time.deltaTime);
        transform.Translate(0, 0, 5 * Time.deltaTime);
    }
}
