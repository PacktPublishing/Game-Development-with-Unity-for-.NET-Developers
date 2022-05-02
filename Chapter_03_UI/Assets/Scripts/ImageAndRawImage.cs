using UnityEngine;
using UnityEngine.UI;

public class ImageAndRawImage : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private RawImage _rawImage;
    [SerializeField] private Texture _texture;

    void Start()
    {
        _image.sprite = _sprite;
        _rawImage.texture = _texture;
    }
}
