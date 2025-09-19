using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class telaVitoria : MonoBehaviour
{

    void voltaMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    private void Update()
    {
        Invoke("voltaMenu", 2);
    }
}
