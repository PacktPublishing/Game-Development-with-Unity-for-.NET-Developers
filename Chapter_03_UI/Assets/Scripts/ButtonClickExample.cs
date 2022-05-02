using UnityEngine;
using UnityEngine.UI;

public class ButtonClickExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var button = GetComponent<Button>();

        button.onClick.AddListener(() =>
        {
            Debug.Log("You have clicked the button!");
        });
    }
}
