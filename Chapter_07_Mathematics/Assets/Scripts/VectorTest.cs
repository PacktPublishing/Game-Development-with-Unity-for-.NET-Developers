using UnityEngine;

public class VectorTest : MonoBehaviour
{
    private Vector3 _vectorA = new Vector3(0, 1, -1);
    private Vector3 _vectorB = new Vector3(5, 0, 5);

    private void Start()
    {
        var result = Vector3.Dot(_vectorA, _vectorB);
        Debug.Log(result);
    }
}
