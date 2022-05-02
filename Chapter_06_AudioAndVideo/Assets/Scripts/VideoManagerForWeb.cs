using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class VideoManagerForWeb : MonoBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;
    [SerializeField] private string _videoFileName;

    void Start()
    {
        if (_videoPlayer == null)
        {
            _videoPlayer = GetComponent<VideoPlayer>();
        }
    }

    public void OnClickSetVideoURL()
    {
        _videoPlayer.url = Path.Combine(Application.streamingAssetsPath, _videoFileName);
    }
}
