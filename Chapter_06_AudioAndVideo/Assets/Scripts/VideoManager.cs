using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;
    [SerializeField] private VideoClip _videoClip;
    [SerializeField] private string _videoURL;
    [SerializeField] private Slider _progressBar;

    void Start()
    {
        if (_videoPlayer == null)
        {
            _videoPlayer = GetComponent<VideoPlayer>();
        }
    }

    private void Update()
    {
        _progressBar.value = (float)_videoPlayer.frame / (float)_videoPlayer.frameCount;
    }

    public void OnClickChangeVideoClip()
    {
        _videoPlayer.clip = _videoClip;
    }

    public void OnClickSetVideoURL()
    {
        _videoPlayer.url = _videoURL;
    }

    public void OnClickPlay()
    {
        _videoPlayer.Play();
        Debug.Log($"frame count: {_videoPlayer.frameCount}");
        Debug.Log($"video length: {_videoPlayer.length}");
        Debug.Log($"frame rate: {_videoPlayer.frameRate}");
    }
}
