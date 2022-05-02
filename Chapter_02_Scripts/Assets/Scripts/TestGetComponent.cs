using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGetComponent : MonoBehaviour
{
    private GameObject _targetGameObject;

    private void Start()
    {
        // Using Find method to find game objects is not recommended,
        // this is just to demonstrate how to call this method to find
        // the target object at runtime.
        _targetGameObject = GameObject.Find("GameObjectTest");
    }

    private void Update()
    {
        if(_targetGameObject == null)
        {
            return;
        }
        var helloWorld = _targetGameObject.GetComponent<HelloWorld>();

        if (helloWorld == null)
        {
            return;
        }

        helloWorld.SayHi();
    }
}
