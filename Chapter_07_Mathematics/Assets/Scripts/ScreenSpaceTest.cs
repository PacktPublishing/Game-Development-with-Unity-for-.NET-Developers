using TMPro;
using UnityEngine;

public class ScreenSpaceTest : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _bfText, _rtText;
    private Camera cam;
    private Ray _ray;

    private void Start()
    {
        cam = Camera.main;
        _bfText.text = "(0, 0)";
        _rtText.text = $"({Screen.width}, {Screen.height})";
    }

    private void Update()
    {
        var mousePosition = Input.mousePosition;
        Debug.Log($"Mouse Position: {mousePosition}");

        var ray = cam.ScreenPointToRay(mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 20, Color.blue);
    }

    private void FixedUpdate()
    {
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray, out RaycastHit hit, 50))
        {
            Debug.DrawLine(_ray.origin, hit.point, Color.red);
        }
    }

}
