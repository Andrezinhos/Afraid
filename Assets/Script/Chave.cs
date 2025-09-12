using UnityEngine;

public class Chave : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Vector3 local;
   
  

    private void Start()
    {
        //Destroy(transform.gameObject, 5);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(0,0);
    }

  }

