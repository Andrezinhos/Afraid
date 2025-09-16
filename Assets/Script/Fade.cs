using UnityEngine;
using UnityEngine.EventSystems;

public class Fade : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject NICTOFOBIA;

    private void Start()
    {
        NICTOFOBIA.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        NICTOFOBIA.SetActive(true);

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        NICTOFOBIA.SetActive(false);

    }
}
