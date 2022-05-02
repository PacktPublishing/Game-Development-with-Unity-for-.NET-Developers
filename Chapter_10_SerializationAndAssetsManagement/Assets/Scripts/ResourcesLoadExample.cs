using UnityEngine;

public class ResourcesLoadExample : MonoBehaviour
{
    private GameObject _gameObjectInstance;

    private void Start()
    {
        var samplePrefab = Resources.Load<GameObject>("SamplePrefab");
        if(samplePrefab != null)
        {
            _gameObjectInstance = Instantiate(samplePrefab);
        }
    }
}
