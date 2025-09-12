using System.Collections;
using UnityEngine;

public class Luzes : MonoBehaviour
{
    public Light targetLight;      // arraste a luz no Inspector
    public float minInterval = 2f; // tempo mínimo entre surtos
    public float maxInterval = 5f; // tempo máximo entre surtos
    public float flashDuration = 1f; // quanto tempo dura o surto de piscadas
    public float flashSpeed = 0.1f;  // velocidade das piscadas
    public float intensityOn = 3f;   // intensidade máxima
    public float intensityOff = 0f;  // intensidade mínima

    void Start()
    {
        if (targetLight == null) targetLight = GetComponent<Light>();
        StartCoroutine(LightRoutine());
    }

    IEnumerator LightRoutine()
    {
        while (true)
        {
            // espera um tempo aleatório até o próximo "surto"
            float wait = Random.Range(minInterval, maxInterval);
            yield return new WaitForSeconds(wait);

            // pisca por um tempo
            float t = 0f;
            while (t < flashDuration)
            {
                targetLight.intensity = (targetLight.intensity == intensityOff) ? intensityOn : intensityOff;
                yield return new WaitForSeconds(flashSpeed);
                t += flashSpeed;
            }

            // garante que termine apagada (opcional)
            targetLight.intensity = intensityOff;
        }
    }
}
    

