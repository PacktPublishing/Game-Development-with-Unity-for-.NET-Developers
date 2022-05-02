using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadAddressableContentFromAzureCloud : MonoBehaviour
{
    [SerializeField]
    private string _assetKey;

    private void Start()
    {
        GetContentFromAzureCloud();
    }

    private async void GetContentFromAzureCloud()
    {
        var resourceLocations = await Addressables.LoadResourceLocationsAsync(_assetKey).Task;

        foreach (var resourceLocation in resourceLocations)
        {
            await Addressables.InstantiateAsync(resourceLocation).Task;
        }
    }
}