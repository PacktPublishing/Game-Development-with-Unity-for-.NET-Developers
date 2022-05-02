using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGUITest : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 200, 100), "Button"))
        {
            Debug.Log("Hello World!");
        }
    }
}
