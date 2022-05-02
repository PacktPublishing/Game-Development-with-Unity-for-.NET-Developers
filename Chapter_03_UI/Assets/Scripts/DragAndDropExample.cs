using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropExample : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private RectTransform _rectTransform;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("This UI image is clicked!!!");
        _rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("This UI image is being dragged!!!");
        
		if (RectTransformUtility.ScreenPointToWorldPointInRectangle(_rectTransform, eventData.position, eventData.pressEventCamera, out var cursorPos))
		{
			_rectTransform.position = cursorPos;
		}
    }
}
