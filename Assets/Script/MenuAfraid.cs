using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAfraid : MonoBehaviour
{
    public void LoadScene(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void Fechar(string quit)
    {
        Application.Quit();
    }

}