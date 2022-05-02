using UnityEngine;
using TMPro;

public class Information : MonoBehaviour
{
    [SerializeField] 
    private TextMeshProUGUI _cars, _fps;

    private int _carCounts;

    public int CarCounts
    {
        set
        {
            _carCounts += value;
            _cars.text = $"Cars: {_carCounts}";
        }
    }

    private void Update()
    {
        var fpsVal = 1/Time.unscaledDeltaTime;
        _fps.text = $"FPS: {fpsVal.ToString("f1")}";
    }
}
