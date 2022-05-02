using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] 
    private HelloWorld _helloWorld;


    void Start()
    {
        _helloWorld = gameObject.AddComponent<HelloWorld>();
    }

}
