using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStartA : MonoBehaviour
{
    private List<int> _listRef;
    public List<int> ListRef => _listRef;


    private void Awake()
    {
        _listRef = new List<int>();
        Debug.Log("AwakeA");

    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    void Start()
    {
        Debug.Log("StartA");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
