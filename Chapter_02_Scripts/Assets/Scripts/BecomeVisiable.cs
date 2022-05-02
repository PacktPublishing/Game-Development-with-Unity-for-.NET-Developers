using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeVisiable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        Debug.Log("OnBecomeInvisible");
    }

    private void OnBecameVisible()
    {
        Debug.Log("OnBecomeVisible");
    }
}
