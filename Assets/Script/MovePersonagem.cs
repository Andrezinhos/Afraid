//using TMPro;
//using UnityEngine;

//public class MovePersonagem : MonoBehaviour
//{

//    public float velocidade = 60;
//    public float velocidadeMaxima = 1;
//    public float forcaPulo = 9;

//    Vector3 inicio;
//    Rigidbody2D rigidbody;
//    Animator animator;
//    bool viradoDireita = true;

//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//    {
//        rigidbody = transform.GetComponent<Rigidbody2D>();
//        animator = transform.GetComponent<Animator>();
//        inicio = transform.position;
//    }

//    // Update is called once per frame
//    void FixedUpdate()
//    {

//        float movimento = Input.GetAxisRaw("Horizontal");

//        if (movimento == 1)
//        {
//            transform.eulerAngles = new Vector2(0, 0);
//            viradoDireita = true;
//        }
//        if (movimento == -1)
//        {
//            transform.eulerAngles = new Vector2(0, 180);
//            viradoDireita = false;
//        }

//        rigidbody.AddForce(new Vector2(movimento * velocidade, 0));
//        rigidbody.linearVelocityX = Mathf.Clamp(rigidbody.linearVelocityX, -velocidadeMaxima, velocidadeMaxima);

//        if (rigidbody.linearVelocityX < 0.1f && rigidbody.linearVelocityX > -0.1f)
//        {
//            animator.SetBool("estaAndando", false);
//        }
//        else
//        {
//            animator.SetBool("estaAndando", true);
//        }

//    }
//}
