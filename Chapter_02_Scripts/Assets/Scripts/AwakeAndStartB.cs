using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStartB : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("AwakeB");
    }

    void Start()
    {
        Debug.Log("StartB");

        var comp = GameObject.Find("A").GetComponent<AwakeAndStartA>();
        Debug.Log($"comp is null > {comp is null}");
        Debug.Log(comp.ListRef.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
