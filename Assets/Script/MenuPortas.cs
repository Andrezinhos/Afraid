using UnityEngine;

public class MenuPortas : MonoBehaviour
{

    public Sprite portaAberta;
    public Sprite portaFechada;
    public GameObject NICTOFOBIA;

    public SpriteRenderer porta2;
    public SpriteRenderer porta3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        porta2.sprite = portaFechada;
        porta3.sprite = portaFechada;
    }

    public void MouseEnterPorta2()
    {
        porta2.sprite = portaAberta;
    }
    public void MouseExitPorta2()
    {
        porta2.sprite = portaFechada;
    }
    public void MouseEnterPorta3()
    {
        porta3.sprite = portaAberta;
    }
    public void MouseExitPorta3()
    {
        porta3.sprite = portaFechada;
    }
}
