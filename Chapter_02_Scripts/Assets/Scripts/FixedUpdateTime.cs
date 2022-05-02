using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 25;
    }

    private void FixedUpdate()
    {
        Debug.Log($"FixedUpdate delta Time{Time.deltaTime}");
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Update delta Time{Time.deltaTime}");
        Debug.Log($"Frame Count {Time.frameCount}");

    }
}
