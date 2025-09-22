using UnityEngine;

public class Inimigo : MonoBehaviour
{
    Transform alvo;
    Vector2 inicio;
    public float velo = 5;
    public int vidas = 3;
    
    void Start()
    {
        inicio = transform.position;
        alvo = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (alvo == null)
        {
            return;
        }

        if (Vector2.Distance(transform.position, alvo.position) < 1.25)
        {
            return;
        }

        Vector3 direcao = alvo.position - transform.position;
        direcao = direcao.normalized;

        transform.position += direcao * velo * Time.deltaTime;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            transform.position = inicio;
        }    

    }
}
