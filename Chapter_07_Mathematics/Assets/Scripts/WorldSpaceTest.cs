using UnityEngine;

public class WorldSpaceTest : MonoBehaviour
{
    private void Start()
    {
        transform.position = new Vector3(0, 1, 0);
    }

    private void Update()
    {
        Debug.Log(Input.mousePosition);
    }
}
