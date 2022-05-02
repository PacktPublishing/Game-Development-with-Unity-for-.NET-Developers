using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    void Start()
    {
        // draw a 5-unit white line from the origin for 2.5 seconds
        Debug.DrawLine(Vector3.zero, new Vector3(2, 5, 0), Color.green);
    }

    private float q = 0.0f;

    void FixedUpdate()
    {
        var vector1 = new Vector3(0, 1, 0);
        var vector2 = new Vector3(1, 0, 1);
        Debug.DrawLine(Vector3.zero, vector1, Color.green);
        Debug.DrawLine(Vector3.zero, vector2, Color.yellow);
        var resultVector = Vector3.Cross(vector1, vector2);
        Debug.DrawLine(Vector3.zero, resultVector, Color.cyan);
    }
}