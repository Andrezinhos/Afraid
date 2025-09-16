using UnityEngine;
using UnityEngine.EventSystems;

public class Fade3 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Pesadelo;

    private void Start()
    {
        Pesadelo.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Pesadelo.SetActive(true);

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Pesadelo.SetActive(false);

    }
}
