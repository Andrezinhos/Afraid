using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class voltarMenu : MonoBehaviour
{
    public string Menu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("PortaTuto") == true)
        {
            SceneManager.LoadScene(Menu);

        }
    }
}
