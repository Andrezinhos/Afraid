using UnityEngine;
using UnityEngine.EventSystems;

public class Fade2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Tutorial;

    private void Start()
    {
        Tutorial.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Tutorial.SetActive(true);

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Tutorial.SetActive(false);

    }
}
