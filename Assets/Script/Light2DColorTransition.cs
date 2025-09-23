using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Light2D))]
public class Light2DColorTransition : MonoBehaviour
{
    [Header("Configura��es da Transi��o")]
    public Color corInicial = Color.white;
    public Color corFinal = Color.red;
    public float tempoDeTransicao = 2f;

    private Light2D light2D;
    private bool isTransitioning = false;

    private void Start()
    {
        // Obt�m o componente Light2D
        light2D = GetComponent<Light2D>();

        // Define a cor inicial na luz
        light2D.color = corInicial;
    }

    private void Update()
    {
        // Se a transi��o n�o estiver em andamento, inicia a transi��o
        if (!isTransitioning)
        {
            StartCoroutine(TransicaoDeCor(corInicial, corFinal, tempoDeTransicao));
        }
    }

    // Coroutine que realiza a transi��o de cor
    private IEnumerator TransicaoDeCor(Color corInicial, Color corFinal, float tempo)
    {
        isTransitioning = true;

        float tempoPassado = 0f;

        while (tempoPassado < tempo)
        {
            // Interpola entre as cores com base no tempo
            light2D.color = Color.Lerp(corInicial, corFinal, tempoPassado / tempo);
            tempoPassado += Time.deltaTime;

            yield return null;
        }

        // Garante que a cor final seja atingida exatamente
        light2D.color = corFinal;

        isTransitioning = false;
    }

    // Fun��o para reiniciar a transi��o
    public void ReiniciarTransicao()
    {
        StopAllCoroutines();
        StartCoroutine(TransicaoDeCor(corInicial, corFinal, tempoDeTransicao));
    }
}
