using UnityEngine;

public class VectorAddition : MonoBehaviour
{
    private float _speed = 1;

    private void Start()
    {
        var vector1 = new Vector3(1, 1, 1);
        var vector2 = new Vector3(1, 2, 3);
        var addVector = vector1 + vector2;
        var subVector = vector1 - vector2;

        Debug.Log($"Addition: {addVector}");
        Debug.Log($"Subtraction: {subVector}");
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }
}
