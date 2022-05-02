using UnityEngine;

public class EulerAnglesTest : MonoBehaviour
{
    private float _x;

    void Update()
    {
        _x += Time.deltaTime * 10;
        var eulerAngles = new Vector3(_x, 0, 0);
        transform.rotation = Quaternion.Euler(eulerAngles);
    }
}
