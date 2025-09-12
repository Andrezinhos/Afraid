using UnityEngine;

public class Inputteste : MonoBehaviour
{
    Rigidbody2D rigib;

    float horizontal;
    float vertical;

    public float velo = 5;

    bool estaDialogo = false;

    void Start()
    {
        rigib = transform.GetComponent<Rigidbody2D>();
        rigib.rotation = 0;
    }

    // Update is called once per frame
    void Update()
    {
            ProcessaInputs();
    }

    void FixedUpdate()
    {
        MoveJogador();
    }

    void ProcessaInputs()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void MoveJogador()
    {
        Vector2 move = new Vector2(horizontal, vertical);
        if (move.magnitude > 1)
        {
            move = move.normalized;
        }
        move = move * velo;

        rigib.linearVelocity = move;
    }
}
