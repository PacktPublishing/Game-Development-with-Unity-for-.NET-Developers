using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class CoroutinesTest : MonoBehaviour
{
    void Start()
    {
        var url = "https://jiadongchen.com";
        StartCoroutine(DownloadFile(url));
    }


    private static IEnumerator DownloadFile(string url)
    {
        var request = UnityWebRequest.Get(url);
        request.timeout = 10;
        yield return request.SendWebRequest();
        if (request.error != null)
        {
            Debug.LogErrorFormat("error： {0}, url is: {1}", request.error, url);
            request.Dispose();
            yield break;
        }

        if (request.isDone)
        {
            Debug.Log(request.downloadHandler.text);
            request.Dispose();
            yield break;
        }
    }
}
