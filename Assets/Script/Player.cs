using TMPro;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.LowLevelPhysics;
using System.Drawing;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

   
    public int velocidade = 1;
    public float horizon;
    public float verti;
    public bool cutscene = false;  
    float cristaly;
    int morte;
    Transform chave;
    Vector2 vect;
    Animator anima;
    //Transform npc;
    Rigidbody2D rigi;
    TextMeshProUGUI texto;
    TextMeshProUGUI texto2;
  
    void Start()
    {
        rigi = transform.GetComponent<Rigidbody2D>();
        anima = transform.GetComponent<Animator>();
        texto = GameObject.Find("Cristal").transform.GetComponent<TextMeshProUGUI>();
        texto2 = GameObject.Find("Morte").transform.GetComponent<TextMeshProUGUI>();
        vect = transform.position;
        chave = GameObject.Find("Chaveorigem").transform;

    }

    // Update is called once per frame
    void Update()
    {
        Transform Instanciado = Instantiate(chave);
        Instanciado.position = transform.position;
        Instanciado.GetComponent<Chave>().enabled = true;
        if (!cutscene)
        {

            ProcessaInputs();
        }
        //RotacionaCutscene();
    }

    private void FixedUpdate()
    {
        //cutscene = false;
        MovePers();



        Rotaciona();

        // RotacionaMouse();

    }

    void ProcessaInputs()
    {
        horizon = Input.GetAxisRaw("Horizontal");
        verti = Input.GetAxisRaw("Vertical");

    }
    void MovePers()
    {
        Vector2 movimento = new Vector2(horizon, verti);

        if (movimento.magnitude > 0)
        {
            movimento = movimento.normalized;
        }

        movimento = movimento * velocidade;


        rigi.linearVelocity = movimento;

        if (horizon < 0.1f && horizon > -0.1f && verti < 0.1f && verti > -0.1f )
        {
            anima.SetBool("estaAndando", false);
        }
        else
        {
            anima.SetBool("estaAndando", true);
        }
 
       

        

    
    }

    void Rotaciona()
    {
        // return earle
        if (horizon == 1)
        {
          transform.eulerAngles = new Vector2(0, 0);
 
        }

        if(horizon == -1)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        if (horizon == 1)
        {
            transform.eulerAngles = new Vector2(0, 0);

        }

        if (horizon == -1)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        
    }

    //void RotacionaMouse()
    //{
    //    Vector3 poseMundMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    Util.OlharObj(transform, poseMundMouse);
    //}

    //void RotacionaCutscene()
    //{


    //    if (Input.GetKey(KeyCode.T))
    //    {
    //        cutscene = true;
    //        Util.OlharObj(transform, GameObject.Find("NPC").gameObject.transform.position);


    //    }


    //    if (Input.GetKey(KeyCode.G) && cutscene == true)
    //    {
    //        cutscene = false;
    //        return;

    //    }


    //}



    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.Contains("dark") == true)
        {
            transform.position = vect;
            morte++;


            Debug.Log("Parabéns !! Você pegou:");

            texto2.text = " <color=purple>" + morte + "</color> /5";


        }
        if (collision.gameObject.name.Contains("cristal") == true)
        {
            cristaly++;
            Destroy(collision.gameObject);

            //Debug.Log("Parabéns !! Você pegou:" + n++);

            texto.text = " <color=purple>" + cristaly + "</color> /5";

            if(cristaly == 1)
            {
                Transform Instanciado = Instantiate(chave);
                Instanciado.position = transform.position;
                Instanciado.GetComponent<Chave>().enabled = false;

                if (collision.gameObject.name.Contains("chaoDestroy") == true)
                {
                    Destroy(collision.gameObject);
                }
            }
        }
    }
}
