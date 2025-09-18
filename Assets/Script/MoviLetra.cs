using UnityEngine;

public class MoviLetra : MonoBehaviour
{
    // A altura m xima que a plataforma vai subir e descer
    public float alturaLimite = 5f;

    // A velocidade da plataforma
    public float velocidade = 2f;

    // A posi  o inicial da plataforma
    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.position;
    }

    void Update()
    {
        float novaPosicaoY = posicaoInicial.y + Mathf.Sin(Time.time * velocidade) * alturaLimite;

        transform.position = new Vector3(posicaoInicial.x, novaPosicaoY, posicaoInicial.z);
    }
}
