using UnityEngine;

public class Player : MonoBehaviour
{

    //public float velocidade = 5;
    //public float velocidadeMaxima = 5;
    //public float velocidadeMin = -5;
    //public float forcaPulo = 10;
    //bool podePular = true;

    
    //Rigidbody2D rigidbody;
    //void Start()
    //{
    //    rigidbody = transform.GetComponent<Rigidbody2D>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    float horizontal = Input.GetAxisRaw("Horizontal");

    //    horizontal = horizontal * velocidade * Time.deltaTime;

    //    Vector2 movimento = new Vector2(horizontal, 0);

    //    rigidbody.linearVelocity += movimento;
    //    rigidbody.linearVelocityX = Mathf.Clamp(rigidbody.linearVelocityX, velocidadeMin, velocidadeMaxima);

    //    bool pulo = Input.GetButtonDown("Jump");

    //    if (pulo == true && podePular == true)
    //    {
    //        rigidbody.AddForce(new Vector2(0, forcaPulo), ForceMode2D.Impulse);
    //        podePular = false;
    //    }
    //}

    //forma 1 de pulo com colisão
    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //   // if (collision.gameObject.layer == LayerMask.GetMask("camadaChao"))
    //        if (collision.gameObject.layer == Constrains.camadaChao)
    //    {
    //        podePular = true;
    //    }
    //}


}

