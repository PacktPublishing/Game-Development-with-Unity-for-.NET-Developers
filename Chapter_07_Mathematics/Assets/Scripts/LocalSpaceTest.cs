using UnityEngine;

public class LocalSpaceTest : MonoBehaviour
{
    private Vector3 _localPosition = new Vector3(-2, 0, 0);
    private Vector3 _localScale = new Vector3(1, 2, 1);
    private Transform _transform;

    private void Start()
    {
        _transform = gameObject.transform;
        _transform.localPosition = _localPosition;
        _transform.localScale = _localScale;
    }
}
