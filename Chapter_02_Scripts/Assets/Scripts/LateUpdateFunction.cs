using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError("Update" + gameObject.name);
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate" + gameObject.name);
        Debug.Log("Frame Count" + Time.frameCount);
    }
}
