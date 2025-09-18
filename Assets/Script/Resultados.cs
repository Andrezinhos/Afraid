using TMPro;
using UnityEngine;

public class Resultados : MonoBehaviour
{
    SpriteRenderer resultados;
    

    private void Start()
    {
        resultados = GameObject.Find("Total").transform.GetComponent<SpriteRenderer>();
        resultados.enabled = false;
      }


    private void Update()
    {
        resultados.enabled = true;
    }






}
