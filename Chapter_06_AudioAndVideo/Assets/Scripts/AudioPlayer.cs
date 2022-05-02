using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private void Start()
    {
        if(_audioSource == null)
        {
            _audioSource = GetComponent<AudioSource>();
        }
    }

    public void OnClickPlayAudioButton()
    {
        _audioSource.Play();
    }

    public void OnClickPauseAudioButton()
    {
        if(_audioSource.isPlaying)
        {
            _audioSource.Pause();
        }
        else
        {
            _audioSource.UnPause();
        }
    }
    public void OnClickStopAndPlayAudioButton()
    {
        if(_audioSource.isPlaying)
        {
            _audioSource.Stop();
        }
        else
        {
            _audioSource.Play();
        }
    }
}
