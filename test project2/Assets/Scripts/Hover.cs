using UnityEngine;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject HoverMenu;

    // Correct method names and parameter casing
    public void OnPointerEnter(PointerEventData eventData)
    {
        HoverMenu.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverMenu.SetActive(false);
    }
}

